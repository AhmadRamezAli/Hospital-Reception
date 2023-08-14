using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    // Define a class called "UnInsuredPatient" that inherits from the "Patient" class
    class UnInsuredPatient : Patient
    {
        // Define a private field to store information about the patient's exemption status
        private bool _isExemption;

        // Define a constructor to initialize the private field and call the base constructor of the "Patient" class
        public UnInsuredPatient(string id, string fname, string lname, decimal age, decimal days, decimal tests, int type, int dep, bool isExemption)
            : base(id, fname, lname, age, days, tests, type, dep)
        {
            IsExemption = isExemption; // Set the exemption status of the patient
        }

        // Define a public property to provide get and set access to the private field
        public bool IsExemption
        {
            set { _isExemption = value; } // Set the exemption status of the patient
            get { return _isExemption; } // Get the exemption status of the patient
        }

        // Override the "calcBill" method to calculate the patient's bill based on their exemption status and age
        protected override double calcBill()
        {
            if (IsExemption || (Age >= 60 || Age <= 6))
            {
                return 0; // Return 0 if the patient is exempt from paying
            }
            else
                return ((double)((Days * 50) + (Tests * 5))); // Calculate and return the bill if the patient is not exempt
        }

        // Override the "showBill" method to provide a string representation of the patient's bill including 
        // the number of days stayed, number of tests taken, age, exemption status, and total bill
        public override string showBill()
        {
            // Create a string representation of the patient's bill including the number of days stayed, 
            // number of tests taken, age, exemption status, and total bill, and return it
            string s = "Days " + ((Days * 50).ToString()) + "\n" +
                "Tests " + ((Tests * 5).ToString()) + "\n" +
                "Age  " + (Age.ToString()) + "\n" +
                "Exemp " + (IsExemption.ToString()) + "\n" + // Convert the exemption status to a string and add it to the string
                "------------------------" + "\n" +
                "Total " + (calcBill().ToString()) + " JOD";

            return s;
        }

        // Override the "ToString" method toprovide a string representation of the patient's information including the exemption status
        public override string ToString()
        {
            return base.ToString() + "\n" +
                "Patient Exemption is :" + IsExemption.ToString(); // Add the exemption status to the string representation of the patient's information
        }
    }
}