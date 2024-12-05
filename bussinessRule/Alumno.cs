using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bussinessRule;

namespace bussinessRule
{
    public class Alumno
    {
        public Alumno(string nombreAlumno, int dniAlumno, double notaAlumno, int idAlumno)
        {
            this.Nombre = nombreAlumno;
            this.DNI = dniAlumno;
            this.Nota = notaAlumno;
            this.codigoDeArea = idAlumno;
        }

        public string Nombre { get; set; }
        public int DNI { get; }
        public double Nota { get; set; }
        public int codigoDeArea { get; set; }
        public string nacionalidad { get; set; }
    }
}