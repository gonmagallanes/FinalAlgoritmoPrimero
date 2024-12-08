using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bussinessRule;

namespace UserInterface
{
    public class ControladorMenus
    {
        MenuAlumno menuAlumnos;
        MenuPais menuPaises;

        public ControladorMenus()
        {
            ListaPaises listaPaises = new ListaPaises();
            this.menuPaises = new MenuPais(listaPaises);

            ListaAlumno listaAlumno = new ListaAlumno(listaPaises);
            this.menuAlumnos = new MenuAlumno(listaAlumno);
        }

        public void elegirMenus()
        {
            string eleccion = "";

            do
            {
                Console.WriteLine("~~~ Elegir Menu ~~~");
                Console.WriteLine("1- Menu Alumnos");
                Console.WriteLine("2- Menu Paises");
                Console.WriteLine("3- Salir");

                eleccion = Console.ReadLine().Trim();

                switchMenus(eleccion);

            } while (eleccion != "3");

        }

        private void switchMenus(string eleccion)
        {

            switch (eleccion)
            {
                case "1":
                    menuAlumnos.MostrarMenuAlumnos();
                    break;
                case "2":
                    menuPaises.mostrarMenuPaises();
                    break;
                case "3":
                    Console.WriteLine("Adios gracias!");
                    break;
            }

        }

    }
}