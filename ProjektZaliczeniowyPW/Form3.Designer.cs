namespace ProjektZaliczeniowyPW
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddCharButton = new System.Windows.Forms.Button();
            this.WariorRadio = new System.Windows.Forms.RadioButton();
            this.MageRadio = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.LVLBox = new System.Windows.Forms.TextBox();
            this.DescriptBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.EditCharacterCombo = new System.Windows.Forms.ComboBox();
            this.LVLEditBox = new System.Windows.Forms.TextBox();
            this.DecriptEditBox = new System.Windows.Forms.TextBox();
            this.NameEditBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LVL";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(262, 259);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.AddCharButton);
            this.tabPage1.Controls.Add(this.WariorRadio);
            this.tabPage1.Controls.Add(this.MageRadio);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.LVLBox);
            this.tabPage1.Controls.Add(this.DescriptBox);
            this.tabPage1.Controls.Add(this.NameBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(254, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            // 
            // AddCharButton
            // 
            this.AddCharButton.Location = new System.Drawing.Point(96, 162);
            this.AddCharButton.Name = "AddCharButton";
            this.AddCharButton.Size = new System.Drawing.Size(135, 23);
            this.AddCharButton.TabIndex = 9;
            this.AddCharButton.Text = "Add Character";
            this.AddCharButton.UseVisualStyleBackColor = true;
            this.AddCharButton.Click += new System.EventHandler(this.AddCharButton_Click);
            // 
            // WariorRadio
            // 
            this.WariorRadio.AutoSize = true;
            this.WariorRadio.Location = new System.Drawing.Point(150, 24);
            this.WariorRadio.Name = "WariorRadio";
            this.WariorRadio.Size = new System.Drawing.Size(56, 17);
            this.WariorRadio.TabIndex = 8;
            this.WariorRadio.TabStop = true;
            this.WariorRadio.Text = "Warior";
            this.WariorRadio.UseVisualStyleBackColor = true;
            // 
            // MageRadio
            // 
            this.MageRadio.AutoSize = true;
            this.MageRadio.Location = new System.Drawing.Point(58, 24);
            this.MageRadio.Name = "MageRadio";
            this.MageRadio.Size = new System.Drawing.Size(52, 17);
            this.MageRadio.TabIndex = 7;
            this.MageRadio.TabStop = true;
            this.MageRadio.Text = "Mage";
            this.MageRadio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Class";
            // 
            // LVLBox
            // 
            this.LVLBox.Location = new System.Drawing.Point(20, 162);
            this.LVLBox.Name = "LVLBox";
            this.LVLBox.Size = new System.Drawing.Size(32, 20);
            this.LVLBox.TabIndex = 6;
            // 
            // DescriptBox
            // 
            this.DescriptBox.Location = new System.Drawing.Point(20, 106);
            this.DescriptBox.Multiline = true;
            this.DescriptBox.Name = "DescriptBox";
            this.DescriptBox.Size = new System.Drawing.Size(183, 37);
            this.DescriptBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(20, 67);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(183, 20);
            this.NameBox.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.DeleteButton);
            this.tabPage2.Controls.Add(this.EditButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.EditCharacterCombo);
            this.tabPage2.Controls.Add(this.LVLEditBox);
            this.tabPage2.Controls.Add(this.DecriptEditBox);
            this.tabPage2.Controls.Add(this.NameEditBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(254, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(160, 192);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(64, 192);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Save";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Choose character to edit";
            // 
            // EditCharacterCombo
            // 
            this.EditCharacterCombo.FormattingEnabled = true;
            this.EditCharacterCombo.Location = new System.Drawing.Point(11, 43);
            this.EditCharacterCombo.Name = "EditCharacterCombo";
            this.EditCharacterCombo.Size = new System.Drawing.Size(198, 21);
            this.EditCharacterCombo.TabIndex = 13;
            this.EditCharacterCombo.SelectedIndexChanged += new System.EventHandler(this.EditCharacterCombo_SelectedIndexChanged);
            // 
            // LVLEditBox
            // 
            this.LVLEditBox.Location = new System.Drawing.Point(11, 192);
            this.LVLEditBox.Name = "LVLEditBox";
            this.LVLEditBox.Size = new System.Drawing.Size(32, 20);
            this.LVLEditBox.TabIndex = 12;
            // 
            // DecriptEditBox
            // 
            this.DecriptEditBox.Location = new System.Drawing.Point(11, 136);
            this.DecriptEditBox.Multiline = true;
            this.DecriptEditBox.Name = "DecriptEditBox";
            this.DecriptEditBox.Size = new System.Drawing.Size(183, 37);
            this.DecriptEditBox.TabIndex = 11;
            // 
            // NameEditBox
            // 
            this.NameEditBox.Location = new System.Drawing.Point(11, 97);
            this.NameEditBox.Name = "NameEditBox";
            this.NameEditBox.Size = new System.Drawing.Size(183, 20);
            this.NameEditBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "LVL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Description";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 286);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Add/Edit Character";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox LVLBox;
        public System.Windows.Forms.TextBox DescriptBox;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox LVLEditBox;
        public System.Windows.Forms.TextBox DecriptEditBox;
        public System.Windows.Forms.TextBox NameEditBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCharButton;
        public System.Windows.Forms.RadioButton WariorRadio;
        public System.Windows.Forms.RadioButton MageRadio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox EditCharacterCombo;
    }
}