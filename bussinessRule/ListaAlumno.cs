using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bussinessRule
{
    public class ListaAlumno
    {
        private List<Alumno> _ListaAlumno = new List<Alumno>();

        private ListaPaises _ListaPaises;

        public bool alumnoExistente(int dni)
        {

            foreach (Alumno alumno in _ListaAlumno)
            {
                if (alumno.DNI == dni)
                {
                    return true;
                }
            }

            return false;

        }

        public bool agregarAlumno(Alumno alumno)
        {
            if (alumnoExistente(alumno.DNI))
            {
                return false;
            }
            else
            {
                _ListaAlumno.Add(alumno);
                return true;
            }
        }

        public bool eliminarAlumno(int dni)
        {

            Alumno eliminar;

            foreach (Alumno alumno in _ListaAlumno)
            {
                if (alumno.DNI == dni)
                {
                    eliminar = alumno;
                    _ListaAlumno.Remove(alumno);
                    return true;
                }
            }
            return false;

        }

        public bool modificarAlumno(int dni, string nombre, string nota)
        {
            foreach (Alumno alumno in _ListaAlumno)
            {
                if (alumno.DNI == dni)
                {
                    alumno.Nombre = nombre;
                    alumno.Nota = int.Parse(nota);

                    return true;
                }
            }
            return false;

        }

        public string buscarAlumno(int dni)
        {

            string alumnoBuscado = "";
            foreach (Alumno alumno in _ListaAlumno)
            {
                if (alumno.DNI == dni)
                {
                    alumnoBuscado = alumno.Nombre;
                }
            }
            return $"El alumno buscado: {alumnoBuscado}";
        }

        public string notaMasAlta()
        {
            double notaAlta = 0;
            string mejorAlumno = "";

            foreach (Alumno alumno in _ListaAlumno)
            {
                if (alumno.Nota >= notaAlta)
                {
                    notaAlta = alumno.Nota;
                    mejorAlumno = alumno.Nombre;

                }
            }
            return $"{mejorAlumno} es el mejor alumno, con una nota de: {notaAlta}";
        }

        public double promedioGeneral()
        {
            double promedio = 0;
            int cantidadAlumnos = 0;

            foreach (Alumno alumno in _ListaAlumno)
            {
                promedio += alumno.Nota;
                cantidadAlumnos++;
            }

            double promedioGeneral = promedio / cantidadAlumnos;
            return promedioGeneral;

        }


        public string mostrarAlumnos()
        {
            string texto = "";

            foreach (Alumno alumno in _ListaAlumno)
            {
                texto += "~~~~~~ \n";

                texto += "Alumno: " + alumno.Nombre + "\n";
                texto += "Nota: " + alumno.Nota + "\n";
                texto += "DNI: " + alumno.DNI + "\n";
                texto += nacionalidaAlumno(alumno.codigoDeArea);
            }
            return texto;
        }

        public string nacionalidaAlumno(int id)
        {
            Alumno alumno;
            Paises pais = _ListaPaises.buscarPaises(id);

            if (pais != null)
            {
                return $"Pais de Nacimiento: {pais.nombrePais}";
            }
            else
            {

                return "chupala";
            }

        }

        public bool listaNoVaciaA()
        {
            if (_ListaAlumno.Count >= 1)
            {
                return true;
            }
            return false;


        }


    }
}