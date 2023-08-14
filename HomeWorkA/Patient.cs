using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    // Define an abstract class called "Patient"
    abstract class Patient
    {
        // Define private fields to store information about the patient
        private string _fname; // patient's first name
        private string _lname; // patient's last name
        private decimal _age; // patient's age
        private int _type; // type of patient (Insured or UnInsured)
        private decimal _days; // number of days the patient stayed at the hospital
        private decimal _tests; // number of tests the patient took
        private int _dep; // department the patient was admitted to
        private string _id; // patient's ID

        // Define public properties to provide get and set access to the private fields
        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        public decimal Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public decimal Days
        {
            get { return _days; }
            set { _days = value; }
        }

        public decimal Tests
        {
            get { return _tests; }
            set { _tests = value; }
        }

        public int Dep
        {
            get { return _dep; }
            set { _dep = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        // Define a constructor to initialize the private fields
        protected Patient(string id, string fname, string lname, decimal age, decimal days, decimal tests, int type, int dep)
        {
            // Set the values of the private fields
            Fname = fname;
            Lname = lname;
            Age = age;
            Type = type;
            Days = days;
            Tests = tests;
            Dep = dep;
            Id = id;
            Fname = fname;
            Lname = lname;
            Age = age;
            Type = type;
            Days = days;
            Tests = tests;
            Dep = dep;
            Id = id;
        }

        // Define abstract methods that are meant to be implemented by any class that inherits from the "Patient" class
        // This method returns a string representation of the patient's bill
        abstract public string showBill();
        // This method calculates the patient's bill
        abstract protected double calcBill();

        // Override the "ToString" method to provide a string representation of the patient's information
        public override string ToString()
        {
            string s = "Patient Id is :" + _id.ToString() + "\n" +
                "Patient Name is :" + _fname + " " + _lname + "\n" +
               "Patient Age is :" + _age.ToString() + "\n" +
               "Patient Department is :" + _dep.ToString();
            return s;
        }

        // Define a method that returns a string representation of the patient's information,
        // including their ID, first and last name, age, and calculated bill
        public string show()
        {
            string depart="";
            if (Dep==1) { depart ="Kids"; }
            if (Dep==2) { depart = "Bones"; }
            if (Dep==3) { depart = "Brain"; }
            if (Dep==4) { depart = "Internal"; }
            if (Dep==5) { depart = "Nervousness"; }
            string s = Id.ToString() +
                "                 " + Fname + "                   " + Lname +
               "                   " + Age.ToString() + "         "+depart+ "              " + (this.calcBill().ToString());
            return s;
        }

    }
}