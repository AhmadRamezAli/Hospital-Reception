using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    // Define a class called "InsuredPatient" that inherits from the "Patient" class
    class InsuredPatient : Patient
    {
        // Define private fields to store information about the patient's insurance
        private double _percentage; // The percentage of the bill that the insurance covers
        private string _company; // The name of the patient's insurance company

        // Define a constructor to initialize the private fields
        public InsuredPatient(string id, string fname, string lname, decimal age, decimal days, decimal tests,
            int type, int dep, double percentage, string company)
            : base(id, fname, lname, age, days, tests, type, dep)
        {
            Percentage = percentage; // Set the insurance coverage percentage
            Company = company; // Set the insurance company name
        }

        // Define public properties to provide get and set access to the private fields
        double Percentage
        {
            set
            {
                _percentage = value; // Set the insurance coverage percentage
            }
            get
            {
                return _percentage; // Get the insurance coverage percentage
            }
        }

        string Company
        {
            set
            {
                _company = value; // Set the insurance company name
            }
            get
            {
                return _company; // Get the insurance company name
            }
        }

        // Override the "calcBill" method to calculate the patient's bill based on their insurance coverage
        protected override double calcBill()
        {
            // Calculate the bill based on the patient's insurance coverage and return it
            return ((double)((Days * 50) + (Tests * 5))) * Percentage;
        }

        // Override the "showBill" method to provide a string representation of the patient's bill including 
        // the number of days stayed, number of tests taken, insurance information, and total bill
        public override string showBill()
        {
            // Create a string representation of the patient's bill and return it
            string s = "Days " + ((Days * 50).ToString()) + "\n" +
                "Tests " + ((Tests * 5).ToString()) + "\n" +
                "Coverage " + (Percentage.ToString()) + "\n" +
                "------------------------" + "\n" +
                "Total " + (this.calcBill().ToString()) + " JOD";
            return s;
        }

        // Override the "ToString" method to provide a string representation of the patient's information
        // including their ID, first and last name, age, department, and insurance information
        public override string ToString()
        {
            // Create a string representation of the patient's information and return it
            return base.ToString() + "\n" + // Call the base class's ToString method to get the patient's basic information
                "Patient Percentage is:" + Percentage.ToString() + "\n" + // Add the patient's insurance coverage percentage
                "Patient Company's Name is:" + Company; // Add the patient's insurance company name

        }
    }
}