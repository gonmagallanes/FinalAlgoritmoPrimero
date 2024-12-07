using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using bussinessRule;

namespace UserInterface
{
    public class MenuAlumno
    {
        ListaAlumno alumnoListado;

        public MenuAlumno(ListaAlumno alumnolistado)
        {
            this.alumnoListado = alumnolistado;

        }
        public void MostrarMenuAlumnos()
        {
            string eleccionAlumno = "";
            do
            {

                Console.WriteLine("\n~~~ Menu Alumnos ~~~ \n ");
                Console.WriteLine(" 1- Ingresar nuevo alumno");
                Console.WriteLine(" 2- Dar de baja alumno ");
                Console.WriteLine(" 3- Modificar datos de un alumno");
                Console.WriteLine(" 4- Buscar alumno por DNI");
                Console.WriteLine(" 5- Nota mas alta del aula");
                Console.WriteLine(" 6- Promedio general del aula");
                Console.WriteLine(" 7- Mostrar Alumnos");
                Console.WriteLine(" 8- Volver al inicio \n");

                eleccionAlumno = Console.ReadLine();

                switchAlumnos(eleccionAlumno);

            } while (eleccionAlumno != "8");
        }

        private void switchAlumnos(string eleccion)
        {
            switch (eleccion)
            {
                case "1":
                    menuAgregar();
                    break;
                case "2":
                    if (alumnoListado.listaNoVaciaA())
                    {
                        menuEliminar();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" \n \n No hay alumnos para eliminar \n \n ");
                    }
                    break;
                case "3":
                    if (alumnoListado.listaNoVaciaA())
                    {
                        menuModificar();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n \n No hay alumnos para modificar \n \n");
                    }
                    break;
                case "4":
                    if (alumnoListado.listaNoVaciaA())
                    {
                        menuBuscar();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n \n No hay alumnos para buscar \n \n");
                    }
                    break;
                case "5":
                    if (alumnoListado.listaNoVaciaA())
                    {
                        menuNota();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n \n No hay alumnos anotados \n \n");
                    }
                    break;
                case "6":
                    if (alumnoListado.listaNoVaciaA())
                    {
                        menuPromedio();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n \n No hay alumnos anotados \n \n");
                    }
                    break;
                case "7":
                    Console.WriteLine(alumnoListado.mostrarAlumnos());
                    break;
                case "8":
                    Console.WriteLine("");
                    break;

            }
        }

        private void menuAgregar()
        {
            try
            {
                Console.WriteLine("Nombre del alumno: ");
                string nombreAlumno = Console.ReadLine();
                Console.WriteLine("Nota del alumno: ");
                double notaAlumno = double.Parse(Console.ReadLine());
                Console.WriteLine("DNI del alumno: ");
                int dniAlumno = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar Codigo de Area");
                int idAlumno = int.Parse(Console.ReadLine());

                if (nombreAlumno != "" && dniAlumno != null && notaAlumno != null && notaAlumno >= 0 && notaAlumno <= 10 && idAlumno > 0)
                {
                    alumnoListado.agregarAlumno(new Alumno(nombreAlumno, dniAlumno, notaAlumno, idAlumno));
                }
                else
                {
                    Console.WriteLine("\n \n Se ingresaron mal los datos, por favor volve a ingresarlos. \n \n ");
                }

            }
            catch
            {
                Console.WriteLine("\n \n Se ingresaron mal los datos, por favor volve a ingresarlos.\n \n ");
            }
        }

        private void menuEliminar()
        {
            try
            {
                Console.WriteLine("Ingresar DNI del alumno que quiere eliminar: ");
                int dniEliminado = int.Parse(Console.ReadLine());

                if (dniEliminado != null)
                {

                    alumnoListado.eliminarAlumno(dniEliminado);
                    Console.WriteLine("Alumno eliminado.");
                }



            }
            catch
            {
                Console.WriteLine("\n \n Datos erroneos, intente nuevamente.\n \n ");
            }
        }

        private void menuModificar()
        {

            try
            {

                string nombreModificado = "";
                string notaModificada = "";
                Console.WriteLine("Ingresar el DNI del Alumno que quiera modificar");
                int DNImodificado = int.Parse(Console.ReadLine());


                if (DNImodificado != 0)
                {
                    Console.WriteLine("Ingrese el nuevo nombre: ");
                    nombreModificado = Console.ReadLine();
                    Console.WriteLine("Ingrese la nueva nota");
                    notaModificada = Console.ReadLine();

                    alumnoListado.modificarAlumno(DNImodificado, nombreModificado, notaModificada);
                }

            }
            catch
            {
                Console.WriteLine("\n \n Numero de DNI no identificado. \n \n ");
            }

        }

        private void menuBuscar()
        {
            try
            {
                Console.WriteLine("Ingresar DNI del alumno a buscar");
                int DNIbuscar = int.Parse(Console.ReadLine());

                if (DNIbuscar != 0)
                {
                    Console.WriteLine(alumnoListado.buscarAlumno(DNIbuscar));
                }
            }
            catch
            {
                Console.WriteLine("\n \n Numero de DNI no identificado. \n \n ");
            }
        }

        private void menuNota()
        {

            Console.WriteLine(alumnoListado.notaMasAlta());

        }

        private void menuPromedio()
        {
            Console.WriteLine($"El promedio general del aula: {alumnoListado.promedioGeneral()}");
        }


    }
}