using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Pwd_Manager;

namespace GUI
{
    public partial class Form1 : Form
    {
        private List<Domain> _listDomain;
        static int _nbDomains = 0;
        private bool NotSaved = false;

        public int NbDomains
        {
            get { return _nbDomains; }
            set
            {
                _nbDomains = value;
                if (_nbDomains == 0)
                {
                    PwdButton.Enabled = false;
                    domainDelete.Enabled = false;
                    deletePwd.Enabled = false;
                    ModifyButton.Enabled = false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            PwdButton.Enabled = false;
            domainDelete.Enabled = false;
            deletePwd.Enabled = false;
            PwdButton.Enabled = false;
            ModifyButton.Enabled = false;
            _listDomain = new List<Domain>();
        }

        private void domainButton_Click(object sender, EventArgs e)
        {
            domainPopup PopUp = new domainPopup();
            if(PopUp.ShowDialog() == DialogResult.OK)
            {
                domainListBox.Items.Add(PopUp.GetText()); // Ajout à la listbox
                _listDomain.Add(new Domain(PopUp.GetText())); // Ajout à la liste
                NbDomains++;
                NotSaved = true;
            }
        }

        private void domainDelete_Click(object sender, EventArgs e)
        {
            int index = domainListBox.SelectedIndex;
            _listDomain.RemoveAt(index); // enlève de la liste
            domainListBox.Items.RemoveAt(index); // enlève de la listbox
            deletePwd.Enabled = false;
            NbDomains--;
            ClearTextBoxes();
            NotSaved = true;
        }

        private void PwdButton_Click(object sender, EventArgs e)
        {
            passwordPopup pwdPopup = new passwordPopup();
            if(pwdPopup.ShowDialog() == DialogResult.OK)
            {
                User obj_user = new User(pwdPopup.GetNickname(), pwdPopup.GetPassword());
                foreach(Domain element in _listDomain)
                {
                    if (element.Domaine == domainListBox.GetItemText(domainListBox.SelectedItem))
                    {
                        string tmp = obj_user.Nickname + ";" + obj_user.Password;
                        element.ListUser.Add(obj_user);
                        PwdListBox.Items.Add(tmp);
                        deletePwd.Enabled = true;
                        NotSaved = true;
                    }
                }
            }
        }

        private void domainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PwdListBox.Items.Clear();
            if(domainListBox.SelectedItem != null)
            {
                PwdButton.Enabled = true;
                domainDelete.Enabled = true;

                foreach(Domain element in _listDomain)
                {
                    if (element.Domaine == domainListBox.GetItemText(domainListBox.SelectedItem))
                    {
                        if (element.ListUser.Count > 0) deletePwd.Enabled = true;
                        else deletePwd.Enabled = false;

                        foreach(User obj_user in element.ListUser)
                        {
                            string tmp = obj_user.Nickname + ";" + obj_user.Password;
                            PwdListBox.Items.Add(tmp);
                        }
                    }
                }
            }
        }

        private void deletePwd_Click(object sender, EventArgs e)
        {
            if(PwdListBox.SelectedItem != null)
            {
                foreach(Domain element in _listDomain)
                {
                    if (element.Domaine == domainListBox.GetItemText(domainListBox.SelectedItem))
                    {
                        int index = PwdListBox.SelectedIndex;
                        element.ListUser.RemoveAt(index); // enlève de la liste
                        PwdListBox.Items.RemoveAt(index);
                        ClearTextBoxes();
                        NotSaved = true;

                        if (element.ListUser.Count == 0)
                        {
                            deletePwd.Enabled = false;
                            ModifyButton.Enabled = false;
                        }
                    }
                }
            }

        }

        private void PwdListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PwdListBox.SelectedItem != null)
            {
                string tmp = PwdListBox.GetItemText(PwdListBox.SelectedItem);
                string[] TabWords = tmp.Split(';');

                nicknameTextBox.Text = TabWords[0];
                passwordTextBox.Text = TabWords[1];
                ModifyButton.Enabled = true;
            }
        }

        private void ClearTextBoxes()
        {
            nicknameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_listDomain.Count > 0)
            {
                CleanupFiles();
                FileManager fp = new FileManager();
                fp.WriteDomains(_listDomain);

                foreach (Domain element in _listDomain)
                {
                    if (element.ListUser.Count > 0)
                    {
                        fp.WritePasswords(element);
                    }
                }
                NotSaved = false;
            }
            else
                MessageBox.Show("Rien à sauvegarder !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager fp = new FileManager();
            string AllDomains = fp.ReadDomains();
            string[] tabDomains = AllDomains.Split(';');
            
            //Avertir l'utilisateur qu'il y a des changements non sauvegardés

            ResetButton.PerformClick();

            for(int i = 0; i < tabDomains.Count(); i++)
            {
                domainListBox.Items.Add(tabDomains[i]);
                Domain tmp = fp.ReadPasswords(tabDomains[i]);
                if(tmp != null)
                    _listDomain.Add(tmp);
            }
        }

        private void CleanupFiles()
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Path += "\\PasswordManager";
            DirectoryInfo dinfo = new DirectoryInfo(Path);
            Directory.CreateDirectory(Path);

            foreach (FileInfo file in dinfo.GetFiles())
                file.Delete();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _listDomain.Clear();
            domainListBox.Items.Clear();
            PwdListBox.Items.Clear();
            nicknameTextBox.Text = "";
            passwordTextBox.Text = "";
            PwdButton.Enabled = false;
            deletePwd.Enabled = false;
            domainDelete.Enabled = false;
            ModifyButton.Enabled = false;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void SortDomainButton_Click(object sender, EventArgs e)
        {
            _listDomain.Sort();
            domainListBox.Items.Clear();
            foreach(Domain element in _listDomain)
            {
                domainListBox.Items.Add(element.Domaine);
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            string newS = nicknameTextBox.Text + ";" + passwordTextBox.Text;
            PwdListBox.Items.Insert(PwdListBox.SelectedIndex, newS);
            PwdListBox.Items.RemoveAt(PwdListBox.SelectedIndex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NotSaved == true)
            {
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                DialogResult r = MessageBox.Show("Des modifications n'ont pas été sauvegardée, quitter quand même?", "Attention !", b, MessageBoxIcon.Warning);
                if (r == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
