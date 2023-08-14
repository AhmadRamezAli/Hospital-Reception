
namespace HomeWorkA
{
    partial class Form1
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.MTestLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.PatientListLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InsuranceCompanyLabel = new System.Windows.Forms.Label();
            this.CoveragePercentageLabel = new System.Windows.Forms.Label();
            this.IsExemptedLabel = new System.Windows.Forms.Label();
            this.AddPatientShowBillButton = new System.Windows.Forms.Button();
            this.ShowPatientsButton = new System.Windows.Forms.Button();
            this.PatientListBox = new System.Windows.Forms.ListBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.LNametextBox = new System.Windows.Forms.TextBox();
            this.FNametextBox = new System.Windows.Forms.TextBox();
            this.AgedomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.MTestdomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.DaysdomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.DepartmentcomboBox = new System.Windows.Forms.ComboBox();
            this.ExemptedButtonTrue = new System.Windows.Forms.RadioButton();
            this.ExemptedButtonFalse = new System.Windows.Forms.RadioButton();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.PatientrichTextBox = new System.Windows.Forms.RichTextBox();
            this.InsuranceCompanytextBox = new System.Windows.Forms.TextBox();
            this.CoveragePercentagedomainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.ShowBillrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedPatientFNameLabel = new System.Windows.Forms.Label();
            this.SelectedPatientLNameLabel = new System.Windows.Forms.Label();
            this.SelectedPatientAgeLabel = new System.Windows.Forms.Label();
            this.SelectedPatientBillLabel = new System.Windows.Forms.Label();
            this.clearFieldButton = new System.Windows.Forms.Button();
            this.selectedPatient = new System.Windows.Forms.Label();
            this.selectedPatientDepLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(38, 34);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 18);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(37, 71);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(66, 18);
            this.FNameLabel.TabIndex = 1;
            this.FNameLabel.Text = "F-Name";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(38, 107);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(66, 18);
            this.LNameLabel.TabIndex = 2;
            this.LNameLabel.Text = "L-Name";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLabel.Location = new System.Drawing.Point(38, 226);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(96, 18);
            this.DepartmentLabel.TabIndex = 3;
            this.DepartmentLabel.Text = "Department";
            // 
            // MTestLabel
            // 
            this.MTestLabel.AutoSize = true;
            this.MTestLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTestLabel.Location = new System.Drawing.Point(37, 182);
            this.MTestLabel.Name = "MTestLabel";
            this.MTestLabel.Size = new System.Drawing.Size(59, 18);
            this.MTestLabel.TabIndex = 4;
            this.MTestLabel.Text = "M-Test";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(38, 145);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(36, 18);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.Text = "Age";
            this.AgeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(38, 303);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(44, 18);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Type";
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLabel.Location = new System.Drawing.Point(37, 264);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(45, 18);
            this.DaysLabel.TabIndex = 7;
            this.DaysLabel.Text = "Days";
            // 
            // PatientListLabel
            // 
            this.PatientListLabel.AutoSize = true;
            this.PatientListLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListLabel.Location = new System.Drawing.Point(14, 344);
            this.PatientListLabel.Name = "PatientListLabel";
            this.PatientListLabel.Size = new System.Drawing.Size(90, 18);
            this.PatientListLabel.TabIndex = 8;
            this.PatientListLabel.Text = "PatientList";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please choose patient type to complete the process";
            // 
            // InsuranceCompanyLabel
            // 
            this.InsuranceCompanyLabel.AutoSize = true;
            this.InsuranceCompanyLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceCompanyLabel.Location = new System.Drawing.Point(353, 36);
            this.InsuranceCompanyLabel.Name = "InsuranceCompanyLabel";
            this.InsuranceCompanyLabel.Size = new System.Drawing.Size(155, 18);
            this.InsuranceCompanyLabel.TabIndex = 10;
            this.InsuranceCompanyLabel.Text = "Insurance Company";
            this.InsuranceCompanyLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CoveragePercentageLabel
            // 
            this.CoveragePercentageLabel.AutoSize = true;
            this.CoveragePercentageLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoveragePercentageLabel.Location = new System.Drawing.Point(353, 71);
            this.CoveragePercentageLabel.Name = "CoveragePercentageLabel";
            this.CoveragePercentageLabel.Size = new System.Drawing.Size(164, 18);
            this.CoveragePercentageLabel.TabIndex = 11;
            this.CoveragePercentageLabel.Text = "CoveragePercentage";
            // 
            // IsExemptedLabel
            // 
            this.IsExemptedLabel.AutoSize = true;
            this.IsExemptedLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsExemptedLabel.Location = new System.Drawing.Point(353, 54);
            this.IsExemptedLabel.Name = "IsExemptedLabel";
            this.IsExemptedLabel.Size = new System.Drawing.Size(100, 18);
            this.IsExemptedLabel.TabIndex = 12;
            this.IsExemptedLabel.Text = "Is Exempted";
            // 
            // AddPatientShowBillButton
            // 
            this.AddPatientShowBillButton.Location = new System.Drawing.Point(356, 105);
            this.AddPatientShowBillButton.Name = "AddPatientShowBillButton";
            this.AddPatientShowBillButton.Size = new System.Drawing.Size(297, 36);
            this.AddPatientShowBillButton.TabIndex = 13;
            this.AddPatientShowBillButton.Text = "Add Patient && show Bill";
            this.AddPatientShowBillButton.UseVisualStyleBackColor = true;
            this.AddPatientShowBillButton.Click += new System.EventHandler(this.AddPatientShowBillButton_Click);
            // 
            // ShowPatientsButton
            // 
            this.ShowPatientsButton.Location = new System.Drawing.Point(775, 352);
            this.ShowPatientsButton.Name = "ShowPatientsButton";
            this.ShowPatientsButton.Size = new System.Drawing.Size(159, 36);
            this.ShowPatientsButton.TabIndex = 14;
            this.ShowPatientsButton.Text = "Show Patients";
            this.ShowPatientsButton.UseVisualStyleBackColor = true;
            this.ShowPatientsButton.Click += new System.EventHandler(this.ShowPatientsButton_Click);
            // 
            // PatientListBox
            // 
            this.PatientListBox.FormattingEnabled = true;
            this.PatientListBox.Location = new System.Drawing.Point(22, 386);
            this.PatientListBox.Name = "PatientListBox";
            this.PatientListBox.Size = new System.Drawing.Size(218, 121);
            this.PatientListBox.TabIndex = 15;
            this.PatientListBox.SelectedIndexChanged += new System.EventHandler(this.PatientListBox_SelectedIndexChanged);
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(166, 34);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(120, 20);
            this.IDtextBox.TabIndex = 17;
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // LNametextBox
            // 
            this.LNametextBox.Location = new System.Drawing.Point(166, 105);
            this.LNametextBox.Name = "LNametextBox";
            this.LNametextBox.Size = new System.Drawing.Size(120, 20);
            this.LNametextBox.TabIndex = 21;
            this.LNametextBox.TextChanged += new System.EventHandler(this.LNametextBox_TextChanged);
            // 
            // FNametextBox
            // 
            this.FNametextBox.Location = new System.Drawing.Point(164, 69);
            this.FNametextBox.Name = "FNametextBox";
            this.FNametextBox.Size = new System.Drawing.Size(120, 20);
            this.FNametextBox.TabIndex = 22;
            this.FNametextBox.TextChanged += new System.EventHandler(this.FNametextBox_TextChanged);
            // 
            // AgedomainUpDown
            // 
            this.AgedomainUpDown.Location = new System.Drawing.Point(166, 143);
            this.AgedomainUpDown.Name = "AgedomainUpDown";
            this.AgedomainUpDown.Size = new System.Drawing.Size(120, 20);
            this.AgedomainUpDown.TabIndex = 26;
            this.AgedomainUpDown.SelectedItemChanged += new System.EventHandler(this.AgedomainUpDown_SelectedItemChanged);
            this.AgedomainUpDown.Click += new System.EventHandler(this.AgedomainUpDown_SelectedItemChanged);
            // 
            // MTestdomainUpDown
            // 
            this.MTestdomainUpDown.Location = new System.Drawing.Point(166, 180);
            this.MTestdomainUpDown.Name = "MTestdomainUpDown";
            this.MTestdomainUpDown.Size = new System.Drawing.Size(120, 20);
            this.MTestdomainUpDown.TabIndex = 27;
            this.MTestdomainUpDown.SelectedItemChanged += new System.EventHandler(this.MTestdomainUpDown_SelectedItemChanged);
            this.MTestdomainUpDown.Click += new System.EventHandler(this.MTestdomainUpDown_SelectedItemChanged);
            // 
            // DaysdomainUpDown
            // 
            this.DaysdomainUpDown.Location = new System.Drawing.Point(165, 262);
            this.DaysdomainUpDown.Name = "DaysdomainUpDown";
            this.DaysdomainUpDown.Size = new System.Drawing.Size(120, 20);
            this.DaysdomainUpDown.TabIndex = 28;
            this.DaysdomainUpDown.SelectedItemChanged += new System.EventHandler(this.DaysdomainUpDown_SelectedItemChanged);
            this.DaysdomainUpDown.Click += new System.EventHandler(this.DaysdomainUpDown_SelectedItemChanged);
            // 
            // DepartmentcomboBox
            // 
            this.DepartmentcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentcomboBox.FormattingEnabled = true;
            this.DepartmentcomboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DepartmentcomboBox.Location = new System.Drawing.Point(165, 223);
            this.DepartmentcomboBox.Name = "DepartmentcomboBox";
            this.DepartmentcomboBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentcomboBox.TabIndex = 29;
            this.DepartmentcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ExemptedButtonTrue
            // 
            this.ExemptedButtonTrue.AutoSize = true;
            this.ExemptedButtonTrue.Location = new System.Drawing.Point(490, 56);
            this.ExemptedButtonTrue.Name = "ExemptedButtonTrue";
            this.ExemptedButtonTrue.Size = new System.Drawing.Size(47, 17);
            this.ExemptedButtonTrue.TabIndex = 31;
            this.ExemptedButtonTrue.TabStop = true;
            this.ExemptedButtonTrue.Text = "True";
            this.ExemptedButtonTrue.UseVisualStyleBackColor = true;
            // 
            // ExemptedButtonFalse
            // 
            this.ExemptedButtonFalse.AutoSize = true;
            this.ExemptedButtonFalse.Location = new System.Drawing.Point(576, 56);
            this.ExemptedButtonFalse.Name = "ExemptedButtonFalse";
            this.ExemptedButtonFalse.Size = new System.Drawing.Size(50, 17);
            this.ExemptedButtonFalse.TabIndex = 32;
            this.ExemptedButtonFalse.TabStop = true;
            this.ExemptedButtonFalse.Text = "False";
            this.ExemptedButtonFalse.UseVisualStyleBackColor = true;
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Location = new System.Drawing.Point(164, 304);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.TypecomboBox.TabIndex = 33;
            this.TypecomboBox.SelectedIndexChanged += new System.EventHandler(this.TypecomboBox_SelectedIndexChanged);
            // 
            // PatientrichTextBox
            // 
            this.PatientrichTextBox.Location = new System.Drawing.Point(356, 352);
            this.PatientrichTextBox.Name = "PatientrichTextBox";
            this.PatientrichTextBox.ReadOnly = true;
            this.PatientrichTextBox.Size = new System.Drawing.Size(398, 127);
            this.PatientrichTextBox.TabIndex = 35;
            this.PatientrichTextBox.Text = "";
            // 
            // InsuranceCompanytextBox
            // 
            this.InsuranceCompanytextBox.Location = new System.Drawing.Point(543, 36);
            this.InsuranceCompanytextBox.Name = "InsuranceCompanytextBox";
            this.InsuranceCompanytextBox.Size = new System.Drawing.Size(110, 20);
            this.InsuranceCompanytextBox.TabIndex = 36;
            // 
            // CoveragePercentagedomainUpDown1
            // 
            this.CoveragePercentagedomainUpDown1.InterceptArrowKeys = false;
            this.CoveragePercentagedomainUpDown1.Location = new System.Drawing.Point(543, 69);
            this.CoveragePercentagedomainUpDown1.Name = "CoveragePercentagedomainUpDown1";
            this.CoveragePercentagedomainUpDown1.Size = new System.Drawing.Size(110, 20);
            this.CoveragePercentagedomainUpDown1.TabIndex = 37;
            this.CoveragePercentagedomainUpDown1.SelectedItemChanged += new System.EventHandler(this.CoveragePercentagedomainUpDown1_SelectedItemChanged);
            this.CoveragePercentagedomainUpDown1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CoveragePercentagedomainUpDown1_SelectedItemChanged);
            // 
            // ShowBillrichTextBox
            // 
            this.ShowBillrichTextBox.Location = new System.Drawing.Point(356, 147);
            this.ShowBillrichTextBox.Name = "ShowBillrichTextBox";
            this.ShowBillrichTextBox.ReadOnly = true;
            this.ShowBillrichTextBox.Size = new System.Drawing.Size(297, 127);
            this.ShowBillrichTextBox.TabIndex = 38;
            this.ShowBillrichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID";
            // 
            // SelectedPatientFNameLabel
            // 
            this.SelectedPatientFNameLabel.AutoSize = true;
            this.SelectedPatientFNameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPatientFNameLabel.Location = new System.Drawing.Point(418, 331);
            this.SelectedPatientFNameLabel.Name = "SelectedPatientFNameLabel";
            this.SelectedPatientFNameLabel.Size = new System.Drawing.Size(66, 18);
            this.SelectedPatientFNameLabel.TabIndex = 40;
            this.SelectedPatientFNameLabel.Text = "F-Name";
            // 
            // SelectedPatientLNameLabel
            // 
            this.SelectedPatientLNameLabel.AutoSize = true;
            this.SelectedPatientLNameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPatientLNameLabel.Location = new System.Drawing.Point(504, 331);
            this.SelectedPatientLNameLabel.Name = "SelectedPatientLNameLabel";
            this.SelectedPatientLNameLabel.Size = new System.Drawing.Size(66, 18);
            this.SelectedPatientLNameLabel.TabIndex = 41;
            this.SelectedPatientLNameLabel.Text = "L-Name";
            // 
            // SelectedPatientAgeLabel
            // 
            this.SelectedPatientAgeLabel.AutoSize = true;
            this.SelectedPatientAgeLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPatientAgeLabel.Location = new System.Drawing.Point(576, 331);
            this.SelectedPatientAgeLabel.Name = "SelectedPatientAgeLabel";
            this.SelectedPatientAgeLabel.Size = new System.Drawing.Size(36, 18);
            this.SelectedPatientAgeLabel.TabIndex = 42;
            this.SelectedPatientAgeLabel.Text = "Age";
            // 
            // SelectedPatientBillLabel
            // 
            this.SelectedPatientBillLabel.AutoSize = true;
            this.SelectedPatientBillLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPatientBillLabel.Location = new System.Drawing.Point(721, 331);
            this.SelectedPatientBillLabel.Name = "SelectedPatientBillLabel";
            this.SelectedPatientBillLabel.Size = new System.Drawing.Size(33, 18);
            this.SelectedPatientBillLabel.TabIndex = 43;
            this.SelectedPatientBillLabel.Text = "Bill";
            // 
            // clearFieldButton
            // 
            this.clearFieldButton.Location = new System.Drawing.Point(775, 413);
            this.clearFieldButton.Name = "clearFieldButton";
            this.clearFieldButton.Size = new System.Drawing.Size(159, 31);
            this.clearFieldButton.TabIndex = 44;
            this.clearFieldButton.Text = "Clear Fields";
            this.clearFieldButton.UseVisualStyleBackColor = true;
            this.clearFieldButton.Click += new System.EventHandler(this.clearFieldButton_Click);
            // 
            // selectedPatient
            // 
            this.selectedPatient.AutoSize = true;
            this.selectedPatient.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPatient.Location = new System.Drawing.Point(353, 304);
            this.selectedPatient.Name = "selectedPatient";
            this.selectedPatient.Size = new System.Drawing.Size(131, 18);
            this.selectedPatient.TabIndex = 45;
            this.selectedPatient.Text = "Selected Patient";
            // 
            // selectedPatientDepLabel
            // 
            this.selectedPatientDepLabel.AutoSize = true;
            this.selectedPatientDepLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPatientDepLabel.Location = new System.Drawing.Point(632, 331);
            this.selectedPatientDepLabel.Name = "selectedPatientDepLabel";
            this.selectedPatientDepLabel.Size = new System.Drawing.Size(37, 18);
            this.selectedPatientDepLabel.TabIndex = 46;
            this.selectedPatientDepLabel.Text = "Dep";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 554);
            this.Controls.Add(this.selectedPatientDepLabel);
            this.Controls.Add(this.selectedPatient);
            this.Controls.Add(this.clearFieldButton);
            this.Controls.Add(this.SelectedPatientBillLabel);
            this.Controls.Add(this.SelectedPatientAgeLabel);
            this.Controls.Add(this.SelectedPatientLNameLabel);
            this.Controls.Add(this.SelectedPatientFNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowBillrichTextBox);
            this.Controls.Add(this.CoveragePercentagedomainUpDown1);
            this.Controls.Add(this.InsuranceCompanytextBox);
            this.Controls.Add(this.PatientrichTextBox);
            this.Controls.Add(this.TypecomboBox);
            this.Controls.Add(this.ExemptedButtonFalse);
            this.Controls.Add(this.ExemptedButtonTrue);
            this.Controls.Add(this.DepartmentcomboBox);
            this.Controls.Add(this.DaysdomainUpDown);
            this.Controls.Add(this.MTestdomainUpDown);
            this.Controls.Add(this.AgedomainUpDown);
            this.Controls.Add(this.FNametextBox);
            this.Controls.Add(this.LNametextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.PatientListBox);
            this.Controls.Add(this.ShowPatientsButton);
            this.Controls.Add(this.AddPatientShowBillButton);
            this.Controls.Add(this.IsExemptedLabel);
            this.Controls.Add(this.CoveragePercentageLabel);
            this.Controls.Add(this.InsuranceCompanyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientListLabel);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.MTestLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "Form1";
            this.Text = "hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label MTestLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label PatientListLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InsuranceCompanyLabel;
        private System.Windows.Forms.Label CoveragePercentageLabel;
        private System.Windows.Forms.Label IsExemptedLabel;
        private System.Windows.Forms.Button AddPatientShowBillButton;
        private System.Windows.Forms.Button ShowPatientsButton;
        private System.Windows.Forms.ListBox PatientListBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox LNametextBox;
        private System.Windows.Forms.TextBox FNametextBox;
        private System.Windows.Forms.DomainUpDown AgedomainUpDown;
        private System.Windows.Forms.DomainUpDown MTestdomainUpDown;
        private System.Windows.Forms.DomainUpDown DaysdomainUpDown;
        private System.Windows.Forms.RadioButton ExemptedButtonTrue;
        private System.Windows.Forms.RadioButton ExemptedButtonFalse;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.RichTextBox PatientrichTextBox;
        private System.Windows.Forms.TextBox InsuranceCompanytextBox;
        private System.Windows.Forms.DomainUpDown CoveragePercentagedomainUpDown1;
        private System.Windows.Forms.RichTextBox ShowBillrichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedPatientFNameLabel;
        private System.Windows.Forms.Label SelectedPatientLNameLabel;
        private System.Windows.Forms.Label SelectedPatientAgeLabel;
        private System.Windows.Forms.Label SelectedPatientBillLabel;
        private System.Windows.Forms.Button clearFieldButton;
        private System.Windows.Forms.Label selectedPatient;
        private System.Windows.Forms.ComboBox DepartmentcomboBox;
        private System.Windows.Forms.Label selectedPatientDepLabel;
    }
}

