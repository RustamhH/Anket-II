namespace Anket_II
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadButton = new System.Windows.Forms.Button();
            this.JsonTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenderChoice = new System.Windows.Forms.GroupBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.FatherNameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.FatherNameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GenderChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(334, 14);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(94, 29);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // JsonTextBox
            // 
            this.JsonTextBox.Location = new System.Drawing.Point(80, 14);
            this.JsonTextBox.Name = "JsonTextBox";
            this.JsonTextBox.PlaceholderText = "Enter Name: ";
            this.JsonTextBox.Size = new System.Drawing.Size(221, 27);
            this.JsonTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenderChoice);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.GenderLabel);
            this.groupBox1.Controls.Add(this.BirthdayLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PhoneLabel);
            this.groupBox1.Controls.Add(this.CityLabel);
            this.groupBox1.Controls.Add(this.CountryLabel);
            this.groupBox1.Controls.Add(this.FatherNameLabel);
            this.groupBox1.Controls.Add(this.SurnameLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.PhoneBox);
            this.groupBox1.Controls.Add(this.CityBox);
            this.groupBox1.Controls.Add(this.CountryBox);
            this.groupBox1.Controls.Add(this.FatherNameBox);
            this.groupBox1.Controls.Add(this.SurnameBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Location = new System.Drawing.Point(80, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // GenderChoice
            // 
            this.GenderChoice.Controls.Add(this.MaleRadioButton);
            this.GenderChoice.Controls.Add(this.FemaleRadioButton);
            this.GenderChoice.Location = new System.Drawing.Point(135, 293);
            this.GenderChoice.Name = "GenderChoice";
            this.GenderChoice.Size = new System.Drawing.Size(207, 47);
            this.GenderChoice.TabIndex = 7;
            this.GenderChoice.TabStop = false;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Checked = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(6, 12);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(63, 24);
            this.MaleRadioButton.TabIndex = 6;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(129, 12);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(78, 24);
            this.FemaleRadioButton.TabIndex = 6;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(6, 307);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(64, 20);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Gender: ";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(6, 265);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(67, 20);
            this.BirthdayLabel.TabIndex = 4;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(6, 220);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(53, 20);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Phone:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(6, 187);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(37, 20);
            this.CityLabel.TabIndex = 4;
            this.CityLabel.Text = "City:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(6, 154);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(63, 20);
            this.CountryLabel.TabIndex = 4;
            this.CountryLabel.Text = "Country:";
            // 
            // FatherNameLabel
            // 
            this.FatherNameLabel.AutoSize = true;
            this.FatherNameLabel.Location = new System.Drawing.Point(6, 95);
            this.FatherNameLabel.Name = "FatherNameLabel";
            this.FatherNameLabel.Size = new System.Drawing.Size(96, 20);
            this.FatherNameLabel.TabIndex = 4;
            this.FatherNameLabel.Text = "Father Name:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(6, 62);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(70, 20);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Surname:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(135, 217);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(207, 27);
            this.PhoneBox.TabIndex = 3;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(135, 184);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(207, 27);
            this.CityBox.TabIndex = 3;
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(135, 151);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(207, 27);
            this.CountryBox.TabIndex = 3;
            // 
            // FatherNameBox
            // 
            this.FatherNameBox.Location = new System.Drawing.Point(135, 92);
            this.FatherNameBox.Name = "FatherNameBox";
            this.FatherNameBox.Size = new System.Drawing.Size(207, 27);
            this.FatherNameBox.TabIndex = 3;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(135, 59);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(207, 27);
            this.SurnameBox.TabIndex = 3;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(135, 26);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(207, 27);
            this.NameBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(80, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(342, 29);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 573);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.JsonTextBox);
            this.Controls.Add(this.LoadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GenderChoice.ResumeLayout(false);
            this.GenderChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoadButton;
        private TextBox JsonTextBox;
        private GroupBox groupBox1;
        private Label NameLabel;
        private TextBox PhoneBox;
        private TextBox CityBox;
        private TextBox CountryBox;
        private TextBox FatherNameBox;
        private TextBox SurnameBox;
        private TextBox NameBox;
        private Label PhoneLabel;
        private Label CityLabel;
        private Label CountryLabel;
        private Label FatherNameLabel;
        private Label SurnameLabel;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private DateTimePicker dateTimePicker1;
        private Label GenderLabel;
        private Label BirthdayLabel;
        private Label label1;
        private Button SaveButton;
        private GroupBox GenderChoice;
    }
}