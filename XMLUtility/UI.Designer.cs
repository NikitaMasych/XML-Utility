﻿namespace XMLUtility
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
            this.secondNameCheckBox = new System.Windows.Forms.CheckBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
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
            this.openInBrowserButton.Click += new System.EventHandler(this.openInBrowserButton_Click);
            // 
            // firstNameCheckbox
            // 
            this.firstNameCheckbox.AutoSize = true;
            this.firstNameCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.firstNameCheckbox.Checked = true;
            this.firstNameCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstNameCheckbox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.firstNameCheckbox.ForeColor = System.Drawing.Color.White;
            this.firstNameCheckbox.Location = new System.Drawing.Point(37, 47);
            this.firstNameCheckbox.Name = "firstNameCheckbox";
            this.firstNameCheckbox.Size = new System.Drawing.Size(135, 34);
            this.firstNameCheckbox.TabIndex = 2;
            this.firstNameCheckbox.Text = "First Name";
            this.firstNameCheckbox.UseVisualStyleBackColor = false;
            // 
            // secondNameCheckBox
            // 
            this.secondNameCheckBox.AutoSize = true;
            this.secondNameCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.secondNameCheckBox.Checked = true;
            this.secondNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.secondNameCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.secondNameCheckBox.ForeColor = System.Drawing.Color.White;
            this.secondNameCheckBox.Location = new System.Drawing.Point(37, 87);
            this.secondNameCheckBox.Name = "secondNameCheckBox";
            this.secondNameCheckBox.Size = new System.Drawing.Size(164, 34);
            this.secondNameCheckBox.TabIndex = 3;
            this.secondNameCheckBox.Text = "Second Name";
            this.secondNameCheckBox.UseVisualStyleBackColor = false;
            // 
            // lastNameCheckBox
            // 
            this.lastNameCheckBox.AutoSize = true;
            this.lastNameCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.lastNameCheckBox.Checked = true;
            this.lastNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lastNameCheckBox.Font = new System.Drawing.Font("Quicksand", 12F);
            this.lastNameCheckBox.ForeColor = System.Drawing.Color.White;
            this.lastNameCheckBox.Location = new System.Drawing.Point(37, 127);
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
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
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
            this.workplaceLabel.Location = new System.Drawing.Point(12, 180);
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
            this.workplaceUniversityCheckBox.Location = new System.Drawing.Point(37, 218);
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
            this.workplaceFacultyCheckbox.Location = new System.Drawing.Point(37, 258);
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
            this.workplaceDepartmentCheckBox.Location = new System.Drawing.Point(37, 298);
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
            this.educationLabel.Location = new System.Drawing.Point(12, 348);
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
            this.postgraduateCheckBox.Location = new System.Drawing.Point(37, 471);
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
            this.basicCheckBox.Location = new System.Drawing.Point(37, 391);
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
            this.graduateCheckBox.Location = new System.Drawing.Point(37, 431);
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
            this.doctoralCheckBox.Location = new System.Drawing.Point(37, 511);
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
            this.DOMRadioButton.Checked = true;
            this.DOMRadioButton.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOMRadioButton.ForeColor = System.Drawing.Color.White;
            this.DOMRadioButton.Location = new System.Drawing.Point(676, 608);
            this.DOMRadioButton.Name = "DOMRadioButton";
            this.DOMRadioButton.Size = new System.Drawing.Size(82, 34);
            this.DOMRadioButton.TabIndex = 14;
            this.DOMRadioButton.TabStop = true;
            this.DOMRadioButton.Text = "DOM";
            this.DOMRadioButton.UseVisualStyleBackColor = false;
            // 
            // SAXRadioButton
            // 
            this.SAXRadioButton.AutoSize = true;
            this.SAXRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SAXRadioButton.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAXRadioButton.ForeColor = System.Drawing.Color.White;
            this.SAXRadioButton.Location = new System.Drawing.Point(804, 608);
            this.SAXRadioButton.Name = "SAXRadioButton";
            this.SAXRadioButton.Size = new System.Drawing.Size(75, 34);
            this.SAXRadioButton.TabIndex = 15;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(405, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 524);
            this.textBox1.TabIndex = 17;
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
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLUtility.Properties.Resources.gradient_linear_blue_purple_1920x1080_c2_00bfff_9400d3_a_90_f_14;
            this.ClientSize = new System.Drawing.Size(904, 688);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.secondNameCheckBox);
            this.Controls.Add(this.firstNameCheckbox);
            this.Controls.Add(this.openInBrowserButton);
            this.Controls.Add(this.transformButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UIForm";
            this.Text = "XML Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.Button openInBrowserButton;
        private System.Windows.Forms.CheckBox firstNameCheckbox;
        private System.Windows.Forms.CheckBox secondNameCheckBox;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button selectButton;
    }
}
