namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.domainListBox = new System.Windows.Forms.ListBox();
            this.PwdListBox = new System.Windows.Forms.ListBox();
            this.domainButton = new System.Windows.Forms.Button();
            this.PwdButton = new System.Windows.Forms.Button();
            this.domainDelete = new System.Windows.Forms.Button();
            this.deletePwd = new System.Windows.Forms.Button();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SortDomainButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem,
            this.chargerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(122, 22);
            this.AboutButton.Text = "A Propos";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // domainListBox
            // 
            this.domainListBox.FormattingEnabled = true;
            this.domainListBox.Location = new System.Drawing.Point(12, 49);
            this.domainListBox.Name = "domainListBox";
            this.domainListBox.Size = new System.Drawing.Size(157, 446);
            this.domainListBox.TabIndex = 1;
            this.domainListBox.SelectedIndexChanged += new System.EventHandler(this.domainListBox_SelectedIndexChanged);
            // 
            // PwdListBox
            // 
            this.PwdListBox.FormattingEnabled = true;
            this.PwdListBox.Location = new System.Drawing.Point(175, 49);
            this.PwdListBox.Name = "PwdListBox";
            this.PwdListBox.Size = new System.Drawing.Size(302, 446);
            this.PwdListBox.TabIndex = 2;
            this.PwdListBox.SelectedIndexChanged += new System.EventHandler(this.PwdListBox_SelectedIndexChanged);
            // 
            // domainButton
            // 
            this.domainButton.Location = new System.Drawing.Point(486, 49);
            this.domainButton.Name = "domainButton";
            this.domainButton.Size = new System.Drawing.Size(99, 37);
            this.domainButton.TabIndex = 3;
            this.domainButton.Text = "Ajouter un domaine";
            this.domainButton.UseVisualStyleBackColor = true;
            this.domainButton.Click += new System.EventHandler(this.domainButton_Click);
            // 
            // PwdButton
            // 
            this.PwdButton.Location = new System.Drawing.Point(486, 93);
            this.PwdButton.Name = "PwdButton";
            this.PwdButton.Size = new System.Drawing.Size(99, 37);
            this.PwdButton.TabIndex = 4;
            this.PwdButton.Text = "Ajouter un mot de passe";
            this.PwdButton.UseVisualStyleBackColor = true;
            this.PwdButton.Click += new System.EventHandler(this.PwdButton_Click);
            // 
            // domainDelete
            // 
            this.domainDelete.Location = new System.Drawing.Point(591, 50);
            this.domainDelete.Name = "domainDelete";
            this.domainDelete.Size = new System.Drawing.Size(98, 36);
            this.domainDelete.TabIndex = 5;
            this.domainDelete.Text = "Supprimer un domaine";
            this.domainDelete.UseVisualStyleBackColor = true;
            this.domainDelete.Click += new System.EventHandler(this.domainDelete_Click);
            // 
            // deletePwd
            // 
            this.deletePwd.Location = new System.Drawing.Point(591, 93);
            this.deletePwd.Name = "deletePwd";
            this.deletePwd.Size = new System.Drawing.Size(98, 37);
            this.deletePwd.TabIndex = 6;
            this.deletePwd.Text = "Supprimer un mot de passe";
            this.deletePwd.UseVisualStyleBackColor = true;
            this.deletePwd.Click += new System.EventHandler(this.deletePwd_Click);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(485, 172);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(204, 20);
            this.nicknameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom de compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(486, 230);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(204, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(615, 450);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Réinitialiser";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortDomainButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SortDomainButton
            // 
            this.SortDomainButton.Image = ((System.Drawing.Image)(resources.GetObject("SortDomainButton.Image")));
            this.SortDomainButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortDomainButton.Name = "SortDomainButton";
            this.SortDomainButton.Size = new System.Drawing.Size(108, 22);
            this.SortDomainButton.Text = "Trier (croissant)";
            this.SortDomainButton.Click += new System.EventHandler(this.SortDomainButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(615, 268);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 21);
            this.ModifyButton.TabIndex = 13;
            this.ModifyButton.Text = "Modifier";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(714, 507);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.deletePwd);
            this.Controls.Add(this.domainDelete);
            this.Controls.Add(this.PwdButton);
            this.Controls.Add(this.domainButton);
            this.Controls.Add(this.PwdListBox);
            this.Controls.Add(this.domainListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ListBox domainListBox;
        private System.Windows.Forms.ListBox PwdListBox;
        private System.Windows.Forms.Button domainButton;
        private System.Windows.Forms.Button PwdButton;
        private System.Windows.Forms.Button domainDelete;
        private System.Windows.Forms.Button deletePwd;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SortDomainButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button ModifyButton;
    }
}

