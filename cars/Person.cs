using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    internal class Person
    {
        //Attributes of person
        public int keyCode { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        License[] licenseSet;
        Car[] carSet;
        public bool supiciousOfFraud { get; set; }


    }
}
