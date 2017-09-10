using System;
using System.Windows.Forms;
using Pwd_Manager;

namespace GUI
{
    public partial class passwordPopup : Form
    {
        public passwordPopup()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.TextLength == 0 || nicknameTextBox.TextLength == 0)
            {
                MessageBox.Show("Les champs pseudo/mot de passe ne peuvent être vide");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string GetNickname()
        {
            return nicknameTextBox.Text;
        }

        public string GetPassword()
        {
            return passwordTextBox.Text;
        }

        private void PwdGenerateButton_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (PwdGenerateTB.TextLength == 0)
                MessageBox.Show("Entrez un nombre dans le champ spécifié");
            else
            {
                if (!int.TryParse(PwdGenerateTB.Text, out parsedValue))
                {
                    MessageBox.Show("Seul un nombre est autorisé");
                }
                else
                {
                    Password tmp = new Password(Convert.ToInt32(PwdGenerateTB.Text));
                    passwordTextBox.Text = tmp.Pwd;
                }
            }
        }
    }
}
