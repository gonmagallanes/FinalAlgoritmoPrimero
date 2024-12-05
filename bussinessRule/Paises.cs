using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bussinessRule
{
    public class Paises
    {
        public Paises(string pais, string capital, int id)
        {
            this.nombrePais = pais;
            this.nombreCapital = capital;
            this.codigoDeArea = id;
        }
        public string nombrePais { get; set; }
        public string nombreCapital { get; set; }
        public int codigoDeArea { get; }

    }
}