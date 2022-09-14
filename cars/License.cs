using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    internal class License
    {
        //Atributes of license
        public DateTime initialDate { get; set; }
        public DateTime expirationDate { get; set; }
        public bool status { get; set; }
        public string type { get; set; }

    }
}
