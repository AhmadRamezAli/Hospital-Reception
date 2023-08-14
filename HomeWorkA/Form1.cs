using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DomainUpDown;
namespace HomeWorkA
{
    public partial class Form1 : Form
    {
        private bool flagcheck = true;
        PatientSystem list = new PatientSystem();
        public Form1()
        {
            InitializeComponent();
            initializeDepartmentComboBox();
            initializeTypeComboBox();
            initializeAgeDomain();
            initializeDaysDomain();
            initializeMTestDomain();
            initializeCoveragePercentageDomain();
            initializeVisible();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgedomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void MTestdomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypecomboBox.Text.Equals("Insured")) initialInsuredVisible();
            else initialUnInsuredVisible();
        }
        private void DaysdomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // This method is called when the "Add Patient & Show Bill" button is clicked.
        private void AddPatientShowBillButton_Click(object sender, EventArgs e)
        {
            // Set flagcheck to true.
            flagcheck = true;
            // Initialize variables.
            double coveragePercentage = 0;
            string id = "";
            string fname = "";
            string lname = "";
            decimal age = 0;
            decimal days = 0;
            decimal mTest = 0;
            int dep = -1;
            string messageBox = "";
            // Try to validate the ID text box input.
            try
            {
                IsValidValue(IDtextBox.Text, "int");
                id = IDtextBox.Text;
            }
            catch (NotValidDataException wrong)
            {
                messageBox += "the field id " + wrong.Message + "\n";
            }

            // Try to validate the first name text box input.
            try
            {
                IsValidValue(FNametextBox.Text, "string");
                fname = FNametextBox.Text;
            }
            catch (NotValidDataException wrong)
            {
                messageBox += "the field F-Name " + wrong.Message + "\n";
            }

            // Try to validate the last name text box input.
            try
            {
                IsValidValue(LNametextBox.Text, "string");
                lname = LNametextBox.Text;
            }
            catch (NotValidDataException wrong)
            {
                messageBox += "the field L-Name " + wrong.Message + "\n";
            }

            // Try to validate the age domain up-down control input.
            try
            {
                IsValidValue(AgedomainUpDown.Text, "decimal");
                age = Decimal.Parse(AgedomainUpDown.Text);
            }
            catch (NotValidDataException wrong)
            {
                messageBox += "the field Age " + wrong.Message + "\n";
            }

            // Try to validate the days domain up-down control input.
            try
            {
                IsValidValue(DaysdomainUpDown.Text, "decimal");
                days = Decimal.Parse(DaysdomainUpDown.Text);
            }
            catch (NotValidDataException wrong)
            {
                messageBox += "the field Days " + wrong.Message + "\n";
            }

            // Try to validate the medical test domain up-down control input.
            try
            {
                IsValidValue(MTestdomainUpDown.Text, "decimal");
                mTest = Decimal.Parse(MTestdomainUpDown.Text);
            }
            catch (NotValidDataException wrong)
            {
                messageBox += "the field M-Test " + wrong.Message + "\n";
            }

            // Try to validate the department combo box input.
            try
            {
                IsValidValue(DepartmentcomboBox.Text, "string");
                if (DepartmentcomboBox.Text.Equals("Kids")) { dep = 1; }
                if (DepartmentcomboBox.Text.Equals("Bones")) { dep = 2; }
                if (DepartmentcomboBox.Text.Equals("Brain")) { dep = 3; }
                if (DepartmentcomboBox.Text.Equals("Internal")) { dep = 4; }
                if (DepartmentcomboBox.Text.Equals("Nervousness")) { dep = 5; }
            }
            catch (EmptyFieldException wrong)
            {
                messageBox += "the field Department " + wrong.Message + "\n";
            }

            // If the patient type is Insured
            if (TypecomboBox.Text.Equals("Insured"))
            {
                // Try to validate the coverage percentage domain up-down control input.
                try
                {
                    IsValidValue(CoveragePercentagedomainUpDown1.Text, "decimal");
                    coveragePercentage = Double.Parse(CoveragePercentagedomainUpDown1.Text);
                    checkCoveragePercentage(coveragePercentage);
                }
                catch (NotValidDataException wrong)
                {
                    messageBox += "the field Coverage Percentage " + wrong.Message + "\n";
                }

                // If flagcheck is true
                if (flagcheck)
                {
                    // Show a message box indicating that the patient was added successfully.
                    MessageBox.Show("The patient is added successfully");
                    // Create a new InsuredPatient object and assign it to the patient variable.
                    Patient patient = new InsuredPatient(id, fname, lname, age,
                        days, mTest, 1, dep, coveragePercentage, InsuranceCompanytextBox.Text);
                    // Set the ShowBill rich text box text to the patient's bill.
                    ShowBillrichTextBox.Text = patient.showBill();
                    // Add the patient's ID to the patient list box.
                    PatientListBox.Items.Add(patient.Id);
                    // Add the patient to the patient list.
                    list.addPatient(patient);
                }
                else
                {
                    // Show a message box with the validation errors.
                    MessageBox.Show(messageBox);
                }
            }
            // If the patient type is Uninsured
            else
            {
                // If neither the ExemptedButtonTrue nor the ExemptedButtonFalse is checked, set flagcheck to false.
                if (ExemptedButtonFalse.Checked == false && ExemptedButtonTrue.Checked == false)
                {
                    flagcheck = false;
                    messageBox += "you should choose the Exempted situation" + "\n";
                }

                // If flagcheck is true
                if (flagcheck)
                {
                    // Show a message box indicating that the patient was added successfully.
                    MessageBox.Show("The patient is added successfully");
                    // Create a new UninsuredPatient object and assign it to the patient variable.
                    Patient patient = new UnInsuredPatient(id, fname, lname, age,
                        days, mTest, 0, dep, ExemptedButtonTrue.Checked);
                    // Set the ShowBill rich text box text to the patient's bill.
                    ShowBillrichTextBox.Text = patient.showBill();
                    //Add the patient's ID to the patient list box.
                    PatientListBox.Items.Add(patient.Id);
                    // Add the patient to the patient list.
                    list.addPatient(patient);
                }
                else
                {
                    // Show a message box with the validation errors.
                    MessageBox.Show(messageBox);
                }
            }
        }

        private void ShowPatientsButton_Click(object sender, EventArgs e)
        {
            if (PatientListBox.SelectedItem == null)
            {
                MessageBox.Show("NO item selected");

            }
            else
                PatientrichTextBox.Text = list.showPatient(PatientListBox.SelectedItem.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // These methods are used to initialize the values of domain up-down controls and combo boxes in a form.
        // The initializeDaysDomain() method sets the value of DaysdomainUpDown control to 0 and populates it with values ranging from 0 to 10000.
        public void initializeDaysDomain()
        {
            DaysdomainUpDown.Text = "0";
            DomainUpDownItemCollection collection = this.DaysdomainUpDown.Items;
            for (int i = 0; i <= 10000; i++)
                collection.Add(i);
            collection.Reverse();
        }

        // The initializeAgeDomain() method sets the value of AgedomainUpDown control to 0 and populates it with values ranging from 0 to 200.
        public void initializeAgeDomain()
        {
            AgedomainUpDown.Text = "0";
            DomainUpDownItemCollection collection = this.AgedomainUpDown.Items;
            for (int i = 0; i <= 200; i++)
                collection.Add(i);
            collection.Reverse();
        }

        // The initializeMTestDomain() method sets the value of MTestdomainUpDown control to 0 and populates it with values ranging from 0 to 100.
        public void initializeMTestDomain()
        {
            MTestdomainUpDown.Text = "0";
            DomainUpDownItemCollection collection = this.MTestdomainUpDown.Items;
            for (int i = 0; i <= 100; i++)
                collection.Add(i);
            collection.Reverse();
        }

        // The initializeCoveragePercentageDomain()method sets the value of CoveragePercentagedomainUpDown1 control to 0 and populates it with values ranging from 0 to 1 with a step size of 0.01.
        public void initializeCoveragePercentageDomain()
        {
            CoveragePercentagedomainUpDown1.Text = "0";
            DomainUpDownItemCollection collection = this.CoveragePercentagedomainUpDown1.Items;
            for (double i = 0; i <= 1; i += 0.01)
                collection.Add(i);
            collection.Reverse();
        }

        // The initializeTypeComboBox() method populates the TypecomboBox control with "Please Choose", "Insured", and "UnInsured" options, and sets the default value to "Please Choose".
        public void initializeTypeComboBox()
        {
            TypecomboBox.Items.Add("Please Choose");
            TypecomboBox.Items.Add("Insured");
            TypecomboBox.Items.Add("UnInsured");
            TypecomboBox.Text = "Please Choose";
        }

        // The initializeDepartmentComboBox() method populates the DepartmentcomboBox control with "Please Choose", "Internal", "Nervousness", "Brain", "Kids", and "Bones" options, and sets the default value to "Please Choose".
        public void initializeDepartmentComboBox()
        {
            DepartmentcomboBox.Items.Add("Please Choose");
            DepartmentcomboBox.Items.Add("Internal");
            DepartmentcomboBox.Items.Add("Nervousness");
            DepartmentcomboBox.Items.Add("Brain");
            DepartmentcomboBox.Items.Add("Kids");
            DepartmentcomboBox.Items.Add("Bones");
            DepartmentcomboBox.Text = "Please Choose";
        }
        public void initializeVisible()
        {
            InsuranceCompanyLabel.Visible = false;
            InsuranceCompanytextBox.Visible = false;
            IsExemptedLabel.Visible = false;
            CoveragePercentagedomainUpDown1.Visible = false;
            CoveragePercentageLabel.Visible = false;
            AddPatientShowBillButton.Visible = false;
            ExemptedButtonTrue.Visible = false;
            ExemptedButtonFalse.Visible = false;
            ShowBillrichTextBox.Visible = false;
        }
        public void initialInsuredVisible()
        {
            InsuranceCompanyLabel.Visible = true;
            InsuranceCompanytextBox.Visible = true;
            IsExemptedLabel.Visible = false;
            CoveragePercentagedomainUpDown1.Visible = true;
            CoveragePercentageLabel.Visible = true;
            AddPatientShowBillButton.Visible = true;
            ExemptedButtonTrue.Visible = false;
            ExemptedButtonFalse.Visible = false;
            ShowBillrichTextBox.Visible = true;
            label1.Visible = false;

        }
        public void initialUnInsuredVisible()
        {
            InsuranceCompanyLabel.Visible = false;
            InsuranceCompanytextBox.Visible = false;
            IsExemptedLabel.Visible = true;
            CoveragePercentagedomainUpDown1.Visible = false;
            CoveragePercentageLabel.Visible = false;
            AddPatientShowBillButton.Visible = true;
            ExemptedButtonTrue.Visible = true;
            ExemptedButtonFalse.Visible = true;
            ShowBillrichTextBox.Visible = true;
            label1.Visible = false;
        }
        // This method is used to validate the input values.
        private bool IsValidValue(string value, string dataType)
        {
            // If the value is an empty string, "Please Choose", or "0", set flagcheck to false and throw an EmptyFieldException.
            if ((value.Equals("") || value.Equals("Please Choose")) || value.Equals("0"))
            {
                flagcheck = false;
                throw new EmptyFieldException();
            }// Switch on the data type.
            switch (dataType.ToLower())
            {
                // If the data type is int.
                case "int":
                    try
                    {
                        // Parse the value as an integer.
                        int.Parse(value);
                        // If the value is less than or equal to 0, throw a NegativeDataException.
                        if (int.Parse(value) <= 0) throw new NegativeDataException();
                        break;
                    }
                    catch (NegativeDataException)
                    {
                        // Set flagcheck to false and throw a NegativeDataException.
                        flagcheck = false;
                        throw new NegativeDataException();
                    }
                    catch (Exception)
                    {
                        // Set flagcheck to false and throw an IntegerDataException.
                        flagcheck = false;
                        throw new IntegerDataException();
                    }

                // If the data type is double.
                case "double":
                    try
                    {
                        // Parse the value as a double.
                        double.Parse(value);
                        // If the value is less than or equal to 0,throw a NegativeDataException.
                        if (double.Parse(value) <= 0) throw new NegativeDataException();
                        break;
                    }
                    catch (NegativeDataException)
                    {
                        // Set flagcheck to false and throw a NegativeDataException.
                        flagcheck = false;
                        throw new NegativeDataException();
                    }
                    catch (Exception)
                    {
                        // Set flagcheck to false and throw a DoubleDataException.
                        flagcheck = false;
                        throw new DoubleDataException();
                    }

                // If the data type is decimal.
                case "decimal":
                    try
                    {
                        // Parse the value as a decimal.
                        decimal.Parse(value);
                        // If the value is less than or equal to 0, throw a NegativeDataException.
                        if (double.Parse(value) <= 0) throw new NegativeDataException();
                        break;
                    }
                    catch (NegativeDataException)
                    {
                        // Set flagcheck to false and throw a NegativeDataException.
                        flagcheck = false;
                        throw new NegativeDataException();
                    }
                    catch (Exception)
                    {
                        // Set flagcheck to false and throw a DecimalDataException.
                        flagcheck = false;
                        throw new DecimalDataException();
                    }

                // If the data type is string.
                case "string":
                    try
                    {
                        // Convert the value to lower case.
                        string value1 = value.ToLower();
                        // Iterate over the characters in the value.
                        for (int i = 0; i < value1.Length; i++)
                        {
                            // If the character is not a letter, set flagcheck to false and throw a NotValidNameException.
                            if (value1[i] < 'a' || value1[i] > 'z')
                            {
                                flagcheck = false;
                                throw new NotValidNameException();
                            }
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        // Set flagcheck to false and throw a NotValidNameException.
                        flagcheck = false;
                        throw new NotValidNameException();
                    }
                    // If the data type is not recognized, return false.
                    return false;
            }
            // If the value is valid, return true.
            return true;
        }

        // This method is used to check if the coverage percentage is greater than 1.
        private void checkCoveragePercentage(double value)
        {
            // If the value is greater than 1, throw a GreaterThanOnePercentageException.
            if (value > 1) throw new GreaterThanOnePercentageException();
        }
        private void clearFieldButton_Click(object sender, EventArgs e)
        {
            FNametextBox.Text = "";
            LNametextBox.Text = "";
            DepartmentcomboBox.Text = "Please Choose";
            TypecomboBox.Text = "Please Choose";
            DaysdomainUpDown.Text = "0";
            AgedomainUpDown.Text = "0";
            MTestdomainUpDown.Text = "0";
            IDtextBox.Text = "";
            ShowBillrichTextBox.Text = "";
            PatientrichTextBox.Text = "";
            ExemptedButtonFalse.Checked = false;
            ExemptedButtonTrue.Checked = false;
            CoveragePercentagedomainUpDown1.Text="0";
            InsuranceCompanytextBox.Text = "";
         
            resetVisible();
        }
        private void resetVisible()
        {
            label1.Visible = true;
            InsuranceCompanyLabel.Visible = false;
            InsuranceCompanytextBox.Visible = false;
            IsExemptedLabel.Visible = false;
            CoveragePercentagedomainUpDown1.Visible = false;
            CoveragePercentageLabel.Visible = false;
            AddPatientShowBillButton.Visible = false;
            ExemptedButtonTrue.Visible = false;
            ExemptedButtonFalse.Visible = false;
            ShowBillrichTextBox.Visible = false;

        }

        private void CoveragePercentagedomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

      
    }
}
