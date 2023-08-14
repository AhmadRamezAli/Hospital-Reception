using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkA
{
    class PatientSystem
    {
        List<Patient> _patients = new List<Patient>();
        public PatientSystem()
        {
            _patients = new List<Patient>();
        }

        public PatientSystem(List<Patient> patients)
        {
            _patients = patients;
        }
        public void addPatient(Patient p)
        {
            _patients.Add(p);
        }
        public bool isExist(string id)
        {
            bool flag = false;
            foreach (Patient patient in _patients) 
            {
                if (patient.Id.Equals(id))
                {
                    flag = true;
                    
                }
            }
            if (flag) return true;
            return false;
        }
        public string [] showPatients()
        { string []s = new string[1000];
            int i = 0;
            foreach(Patient patient in _patients)
            {
                s[i] = patient.ToString();
                i++;
            }
            return s;
        }
        public string showPatient(string id)
        {

            if (isExist(id))
            {
                foreach (Patient p in _patients)
                {
                    if (p.Id.Equals(id))
                    {
                        return p.show();
                    }
                }
            }
            return "No Patient has this ID";
        }
    }
}
