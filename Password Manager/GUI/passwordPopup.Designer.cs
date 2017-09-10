namespace GUI
{
    partial class passwordPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonOK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.LabelNickname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PwdGenerateTB = new System.Windows.Forms.TextBox();
            this.PwdGenerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(191, 205);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 0;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(272, 205);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(146, 42);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nicknameTextBox.TabIndex = 2;
            // 
            // LabelNickname
            // 
            this.LabelNickname.AutoSize = true;
            this.LabelNickname.Location = new System.Drawing.Point(12, 45);
            this.LabelNickname.Name = "LabelNickname";
            this.LabelNickname.Size = new System.Drawing.Size(128, 13);
            this.LabelNickname.TabIndex = 3;
            this.LabelNickname.Text = "Entrez un nom de compte";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 71);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(118, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Entrez un mot de passe";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(146, 68);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Générer un mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Taille";
            // 
            // PwdGenerateTB
            // 
            this.PwdGenerateTB.Location = new System.Drawing.Point(146, 144);
            this.PwdGenerateTB.Name = "PwdGenerateTB";
            this.PwdGenerateTB.Size = new System.Drawing.Size(119, 20);
            this.PwdGenerateTB.TabIndex = 8;
            // 
            // PwdGenerateButton
            // 
            this.PwdGenerateButton.Location = new System.Drawing.Point(272, 142);
            this.PwdGenerateButton.Name = "PwdGenerateButton";
            this.PwdGenerateButton.Size = new System.Drawing.Size(75, 23);
            this.PwdGenerateButton.TabIndex = 9;
            this.PwdGenerateButton.Text = "Générer";
            this.PwdGenerateButton.UseVisualStyleBackColor = true;
            this.PwdGenerateButton.Click += new System.EventHandler(this.PwdGenerateButton_Click);
            // 
            // passwordPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 235);
            this.Controls.Add(this.PwdGenerateButton);
            this.Controls.Add(this.PwdGenerateTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.LabelNickname);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ButtonOK);
            this.Name = "passwordPopup";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Label LabelNickname;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PwdGenerateTB;
        private System.Windows.Forms.Button PwdGenerateButton;
    }
}