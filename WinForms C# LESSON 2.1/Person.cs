using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_C__LESSON_2._1
{
    public class Person
    {
        public Person(string name, string surname, string veteni, DateTime dateTime, bool cinsiyet, string email, bool evlidi, bool isiVar)
        {
            this.name = name;
            this.surname = surname;
            this.veteni = veteni;
            DateTime = dateTime;
            this.cinsiyet = cinsiyet;
            this.email = email;
            this.evlidi = evlidi;
            this.isiVar = isiVar;
        }

        public string name { get; set; }   
        public string surname { get; set; }   
        public string veteni { get; set; }   
        public DateTime DateTime { get; set; }
        public bool cinsiyet { get; set; }
        public string email { get; set; }
        public bool evlidi { get; set; }
        public bool isiVar { get; set; }

    }
}
