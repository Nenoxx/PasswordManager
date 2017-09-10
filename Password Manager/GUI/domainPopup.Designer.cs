namespace GUI
{
    partial class domainPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du domaine :";
            // 
            // domainTextBox
            // 
            this.domainTextBox.Location = new System.Drawing.Point(112, 52);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(177, 20);
            this.domainTextBox.TabIndex = 1;
            this.domainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.domainTextBox_KeyDown);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(148, 110);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(230, 110);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // domainPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 145);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.domainTextBox);
            this.Controls.Add(this.label1);
            this.Name = "domainPopup";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancel;
    }
}