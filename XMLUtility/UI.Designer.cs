namespace XMLUtility
{
    partial class UIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIForm));
            this.transformButton = new System.Windows.Forms.Button();
            this.openInBrowserButton = new System.Windows.Forms.Button();
            this.firstNameCheckbox = new System.Windows.Forms.CheckBox();
            this.surnameCheckBox = new System.Windows.Forms.CheckBox();
            this.lastNameCheckBox = new System.Windows.Forms.CheckBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.workplaceLabel = new System.Windows.Forms.Label();
            this.workplaceUniversityCheckBox = new System.Windows.Forms.CheckBox();
            this.workplaceFacultyCheckbox = new System.Windows.Forms.CheckBox();
            this.workplaceDepartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.educationLabel = new System.Windows.Forms.Label();
            this.postgraduateCheckBox = new System.Windows.Forms.CheckBox();
            this.basicCheckBox = new System.Windows.Forms.CheckBox();
            this.graduateCheckBox = new System.Windows.Forms.CheckBox();
            this.doctoralCheckBox = new System.Windows.Forms.CheckBox();
            this.DOMRadioButton = new System.Windows.Forms.RadioButton();
            this.SAXRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.filteredDataTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.credentialsTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.credentialsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // transformButton
            // 
            this.transformButton.BackColor = System.Drawing.Color.Cyan;
            this.transformButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transformButton.FlatAppearance.BorderSize = 0;
            this.transformButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transformButton.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transformButton.ForeColor = System.Drawing.Color.Black;
            this.transformButton.Location = new System.Drawing.Point(34, 602);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(129, 45);
            this.transformButton.TabIndex = 0;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = false;
            this.transformButton.Click += new System.EventHandler(this.TransformButton_Click);
            // 
            // openInBrowserButton
            // 
            this.openInBrowserButton.BackColor = System.Drawing.Color.Fuchsia;
            this.openInBrowserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openInBrowserButton.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openInBrowserButton.ForeColor = System.Drawing.Color.White;
            this.openInBrowserButton.Location = new System.Drawing.Point(185, 602);
            this.openInBrowserButton.Name = "openInBrowserButton";
            this.openInBrowserButton.Size = new System.Drawing.Size(156, 45);
            this.openInBrowserButton.TabIndex = 1;
            this.openInBrowserButton.Text = "Open in browser";
            this.openInBrowserButton.UseVisualStyleBackColor = false;
            this.openInBrowserButton.Click += new System.EventHandler(this.OpenInBrowserButton_Click);
            // 
            // firstNameCheckbox
            // 
            this.firstNameCheckbox.AutoSize = true;
            this.firstNameCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.firstNameCheckbox.Checked = true;
            this.firstNameCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstNameCheckbox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.firstNameCheckbox.ForeColor = System.Drawing.Color.White;
            this.firstNameCheckbox.Location = new System.Drawing.Point(32, 93);
            this.firstNameCheckbox.Name = "firstNameCheckbox";
            this.firstNameCheckbox.Size = new System.Drawing.Size(135, 34);
            this.firstNameCheckbox.TabIndex = 2;
            this.firstNameCheckbox.Text = "First Name";
            this.firstNameCheckbox.UseVisualStyleBackColor = false;
            // 
            // surnameCheckBox
            // 
            this.surnameCheckBox.AutoSize = true;
            this.surnameCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.surnameCheckBox.Checked = true;
            this.surnameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.surnameCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.surnameCheckBox.ForeColor = System.Drawing.Color.White;
            this.surnameCheckBox.Location = new System.Drawing.Point(33, 133);
            this.surnameCheckBox.Name = "surnameCheckBox";
            this.surnameCheckBox.Size = new System.Drawing.Size(118, 34);
            this.surnameCheckBox.TabIndex = 3;
            this.surnameCheckBox.Text = "Surname";
            this.surnameCheckBox.UseVisualStyleBackColor = false;
            // 
            // lastNameCheckBox
            // 
            this.lastNameCheckBox.AutoSize = true;
            this.lastNameCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.lastNameCheckBox.Checked = true;
            this.lastNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lastNameCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.lastNameCheckBox.ForeColor = System.Drawing.Color.White;
            this.lastNameCheckBox.Location = new System.Drawing.Point(33, 173);
            this.lastNameCheckBox.Name = "lastNameCheckBox";
            this.lastNameCheckBox.Size = new System.Drawing.Size(135, 34);
            this.lastNameCheckBox.TabIndex = 4;
            this.lastNameCheckBox.Text = "Last Name";
            this.lastNameCheckBox.UseVisualStyleBackColor = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(12, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 30);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // workplaceLabel
            // 
            this.workplaceLabel.AutoSize = true;
            this.workplaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.workplaceLabel.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workplaceLabel.Location = new System.Drawing.Point(12, 210);
            this.workplaceLabel.Name = "workplaceLabel";
            this.workplaceLabel.Size = new System.Drawing.Size(117, 30);
            this.workplaceLabel.TabIndex = 6;
            this.workplaceLabel.Text = "Workplace:";
            // 
            // workplaceUniversityCheckBox
            // 
            this.workplaceUniversityCheckBox.AutoSize = true;
            this.workplaceUniversityCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.workplaceUniversityCheckBox.Checked = true;
            this.workplaceUniversityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workplaceUniversityCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.workplaceUniversityCheckBox.ForeColor = System.Drawing.Color.White;
            this.workplaceUniversityCheckBox.Location = new System.Drawing.Point(37, 252);
            this.workplaceUniversityCheckBox.Name = "workplaceUniversityCheckBox";
            this.workplaceUniversityCheckBox.Size = new System.Drawing.Size(126, 34);
            this.workplaceUniversityCheckBox.TabIndex = 7;
            this.workplaceUniversityCheckBox.Text = "University";
            this.workplaceUniversityCheckBox.UseVisualStyleBackColor = false;
            // 
            // workplaceFacultyCheckbox
            // 
            this.workplaceFacultyCheckbox.AutoSize = true;
            this.workplaceFacultyCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.workplaceFacultyCheckbox.Checked = true;
            this.workplaceFacultyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workplaceFacultyCheckbox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.workplaceFacultyCheckbox.ForeColor = System.Drawing.Color.White;
            this.workplaceFacultyCheckbox.Location = new System.Drawing.Point(37, 292);
            this.workplaceFacultyCheckbox.Name = "workplaceFacultyCheckbox";
            this.workplaceFacultyCheckbox.Size = new System.Drawing.Size(102, 34);
            this.workplaceFacultyCheckbox.TabIndex = 8;
            this.workplaceFacultyCheckbox.Text = "Faculty";
            this.workplaceFacultyCheckbox.UseVisualStyleBackColor = false;
            // 
            // workplaceDepartmentCheckBox
            // 
            this.workplaceDepartmentCheckBox.AutoSize = true;
            this.workplaceDepartmentCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.workplaceDepartmentCheckBox.Checked = true;
            this.workplaceDepartmentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workplaceDepartmentCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.workplaceDepartmentCheckBox.ForeColor = System.Drawing.Color.White;
            this.workplaceDepartmentCheckBox.Location = new System.Drawing.Point(37, 332);
            this.workplaceDepartmentCheckBox.Name = "workplaceDepartmentCheckBox";
            this.workplaceDepartmentCheckBox.Size = new System.Drawing.Size(147, 34);
            this.workplaceDepartmentCheckBox.TabIndex = 9;
            this.workplaceDepartmentCheckBox.Text = "Department";
            this.workplaceDepartmentCheckBox.UseVisualStyleBackColor = false;
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.BackColor = System.Drawing.Color.Transparent;
            this.educationLabel.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationLabel.Location = new System.Drawing.Point(12, 383);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(108, 30);
            this.educationLabel.TabIndex = 10;
            this.educationLabel.Text = "Education:";
            // 
            // postgraduateCheckBox
            // 
            this.postgraduateCheckBox.AutoSize = true;
            this.postgraduateCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.postgraduateCheckBox.Checked = true;
            this.postgraduateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.postgraduateCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.postgraduateCheckBox.ForeColor = System.Drawing.Color.White;
            this.postgraduateCheckBox.Location = new System.Drawing.Point(37, 496);
            this.postgraduateCheckBox.Name = "postgraduateCheckBox";
            this.postgraduateCheckBox.Size = new System.Drawing.Size(160, 34);
            this.postgraduateCheckBox.TabIndex = 11;
            this.postgraduateCheckBox.Text = "Postgraduate";
            this.postgraduateCheckBox.UseVisualStyleBackColor = false;
            // 
            // basicCheckBox
            // 
            this.basicCheckBox.AutoSize = true;
            this.basicCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.basicCheckBox.Checked = true;
            this.basicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.basicCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.basicCheckBox.ForeColor = System.Drawing.Color.White;
            this.basicCheckBox.Location = new System.Drawing.Point(34, 416);
            this.basicCheckBox.Name = "basicCheckBox";
            this.basicCheckBox.Size = new System.Drawing.Size(83, 34);
            this.basicCheckBox.TabIndex = 11;
            this.basicCheckBox.Text = "Basic";
            this.basicCheckBox.UseVisualStyleBackColor = false;
            // 
            // graduateCheckBox
            // 
            this.graduateCheckBox.AutoSize = true;
            this.graduateCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.graduateCheckBox.Checked = true;
            this.graduateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.graduateCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.graduateCheckBox.ForeColor = System.Drawing.Color.White;
            this.graduateCheckBox.Location = new System.Drawing.Point(34, 456);
            this.graduateCheckBox.Name = "graduateCheckBox";
            this.graduateCheckBox.Size = new System.Drawing.Size(122, 34);
            this.graduateCheckBox.TabIndex = 12;
            this.graduateCheckBox.Text = "Graduate";
            this.graduateCheckBox.UseVisualStyleBackColor = false;
            // 
            // doctoralCheckBox
            // 
            this.doctoralCheckBox.AutoSize = true;
            this.doctoralCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.doctoralCheckBox.Checked = true;
            this.doctoralCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doctoralCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.doctoralCheckBox.ForeColor = System.Drawing.Color.White;
            this.doctoralCheckBox.Location = new System.Drawing.Point(37, 536);
            this.doctoralCheckBox.Name = "doctoralCheckBox";
            this.doctoralCheckBox.Size = new System.Drawing.Size(115, 34);
            this.doctoralCheckBox.TabIndex = 13;
            this.doctoralCheckBox.Text = "Doctoral";
            this.doctoralCheckBox.UseVisualStyleBackColor = false;
            // 
            // DOMRadioButton
            // 
            this.DOMRadioButton.AutoSize = true;
            this.DOMRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.DOMRadioButton.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOMRadioButton.ForeColor = System.Drawing.Color.White;
            this.DOMRadioButton.Location = new System.Drawing.Point(676, 608);
            this.DOMRadioButton.Name = "DOMRadioButton";
            this.DOMRadioButton.Size = new System.Drawing.Size(82, 34);
            this.DOMRadioButton.TabIndex = 14;
            this.DOMRadioButton.Text = "DOM";
            this.DOMRadioButton.UseVisualStyleBackColor = false;
            // 
            // SAXRadioButton
            // 
            this.SAXRadioButton.AutoSize = true;
            this.SAXRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SAXRadioButton.Checked = true;
            this.SAXRadioButton.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAXRadioButton.ForeColor = System.Drawing.Color.White;
            this.SAXRadioButton.Location = new System.Drawing.Point(804, 608);
            this.SAXRadioButton.Name = "SAXRadioButton";
            this.SAXRadioButton.Size = new System.Drawing.Size(75, 34);
            this.SAXRadioButton.TabIndex = 15;
            this.SAXRadioButton.TabStop = true;
            this.SAXRadioButton.Text = "SAX";
            this.SAXRadioButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(409, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Selection approach:";
            // 
            // filteredDataTextBox
            // 
            this.filteredDataTextBox.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredDataTextBox.Location = new System.Drawing.Point(405, 55);
            this.filteredDataTextBox.Multiline = true;
            this.filteredDataTextBox.Name = "filteredDataTextBox";
            this.filteredDataTextBox.ReadOnly = true;
            this.filteredDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filteredDataTextBox.Size = new System.Drawing.Size(474, 524);
            this.filteredDataTextBox.TabIndex = 17;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.BlueViolet;
            this.selectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.Color.White;
            this.selectButton.Location = new System.Drawing.Point(224, 536);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(117, 45);
            this.selectButton.TabIndex = 18;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(904, 33);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.credentialsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Image = global::XMLUtility.Properties.Resources.Documentation;
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.DocumentationToolStripMenuItem_Click);
            // 
            // credentialsToolStripMenuItem
            // 
            this.credentialsToolStripMenuItem.Image = global::XMLUtility.Properties.Resources.Info_1;
            this.credentialsToolStripMenuItem.Name = "credentialsToolStripMenuItem";
            this.credentialsToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.credentialsToolStripMenuItem.Text = "Credentials";
            this.credentialsToolStripMenuItem.Click += new System.EventHandler(this.ShowCredentials_Click);
            // 
            // credentialsPanel
            // 
            this.credentialsPanel.BackColor = System.Drawing.Color.Black;
            this.credentialsPanel.Controls.Add(this.button1);
            this.credentialsPanel.Controls.Add(this.credentialsTextBox);
            this.credentialsPanel.Location = new System.Drawing.Point(295, 106);
            this.credentialsPanel.Name = "credentialsPanel";
            this.credentialsPanel.Size = new System.Drawing.Size(327, 202);
            this.credentialsPanel.TabIndex = 20;
            this.credentialsPanel.Visible = false;
            this.credentialsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveCredentialsPanel_MouseDown);
            this.credentialsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCredentialsPanel_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(140, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HideCredentials_Click);
            // 
            // credentialsTextBox
            // 
            this.credentialsTextBox.BackColor = System.Drawing.Color.Black;
            this.credentialsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.credentialsTextBox.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsTextBox.ForeColor = System.Drawing.Color.White;
            this.credentialsTextBox.Location = new System.Drawing.Point(3, 36);
            this.credentialsTextBox.Multiline = true;
            this.credentialsTextBox.Name = "credentialsTextBox";
            this.credentialsTextBox.ReadOnly = true;
            this.credentialsTextBox.Size = new System.Drawing.Size(321, 166);
            this.credentialsTextBox.TabIndex = 0;
            this.credentialsTextBox.Text = "XML Utility\r\nMade by Nikita Masych\r\nYou may contact developer using\r\nTelegram: @J" +
    "ust_law_abiding_citizen\r\nEmail: nikitamasich152@gmail.com\r\nDistributed under MIT" +
    " License 2022";
            this.credentialsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLUtility.Properties.Resources.XMLUtilities;
            this.ClientSize = new System.Drawing.Size(904, 688);
            this.Controls.Add(this.credentialsPanel);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.filteredDataTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SAXRadioButton);
            this.Controls.Add(this.DOMRadioButton);
            this.Controls.Add(this.doctoralCheckBox);
            this.Controls.Add(this.graduateCheckBox);
            this.Controls.Add(this.basicCheckBox);
            this.Controls.Add(this.postgraduateCheckBox);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.workplaceDepartmentCheckBox);
            this.Controls.Add(this.workplaceFacultyCheckbox);
            this.Controls.Add(this.workplaceUniversityCheckBox);
            this.Controls.Add(this.workplaceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameCheckBox);
            this.Controls.Add(this.surnameCheckBox);
            this.Controls.Add(this.firstNameCheckbox);
            this.Controls.Add(this.openInBrowserButton);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "UIForm";
            this.Text = "XML Utility";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.credentialsPanel.ResumeLayout(false);
            this.credentialsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.Button openInBrowserButton;
        private System.Windows.Forms.CheckBox firstNameCheckbox;
        private System.Windows.Forms.CheckBox surnameCheckBox;
        private System.Windows.Forms.CheckBox lastNameCheckBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label workplaceLabel;
        private System.Windows.Forms.CheckBox workplaceUniversityCheckBox;
        private System.Windows.Forms.CheckBox workplaceFacultyCheckbox;
        private System.Windows.Forms.CheckBox workplaceDepartmentCheckBox;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.CheckBox postgraduateCheckBox;
        private System.Windows.Forms.CheckBox basicCheckBox;
        private System.Windows.Forms.CheckBox graduateCheckBox;
        private System.Windows.Forms.CheckBox doctoralCheckBox;
        private System.Windows.Forms.RadioButton DOMRadioButton;
        private System.Windows.Forms.RadioButton SAXRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filteredDataTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credentialsToolStripMenuItem;
        private System.Windows.Forms.Panel credentialsPanel;
        private System.Windows.Forms.TextBox credentialsTextBox;
        private System.Windows.Forms.Button button1;
    }
}

