using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Diplom {
    public class Patient
    {
        DateTime DateOnly = new DateTime();
        string surname;
        string name;
        string lastname;
        string gender;
        private List<Symptom> symptoms = new List<Symptom>();
        public Patient(string sn, string n, string ln, string gender, DateTime bd)
        {
            this.surname = sn;
            this.name = n;
            this.lastname = ln;
            this.gender = gender;
            this.DateOnly = bd;
        }
        public void set_symptoms(List<Symptom> symptom)
        {
            this.symptoms = symptom;
        }

        public DateTime get_BD_patient()
        {
            return DateOnly;
        }
    }
}
