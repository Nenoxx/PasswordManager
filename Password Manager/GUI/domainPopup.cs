using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class domainPopup : Form
    {
        public domainPopup()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if(domainTextBox.TextLength != 0)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Le champ ne peut être vide !");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string GetText()
        {
            if (domainTextBox.TextLength != 0)
                return domainTextBox.Text;
            else
                return "NOT FOUND";
        }

        private void domainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OKbutton.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
