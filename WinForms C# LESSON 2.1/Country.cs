using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_C__LESSON_2._1
{
    public class Country
    {
        public Country()
        {
        }

        public Country(string name, string code)
        {
            this.name = name;
            this.code = code;
        }

        public string name { get; set; }
        public string code { get; set; }
    }
}
