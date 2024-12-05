using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bussinessRule;

namespace UserInterface
{
    public class ControladorMenus
    {
        MenuAlumno menuAlumnos = new MenuAlumno();
        MenuPais menuPaises = new MenuPais();
        public void elegirMenus()
        {
            string eleccion = "";

            do
            {
                Console.WriteLine("~~~ Elegir Menu ~~~");
                Console.WriteLine("1- Menu Alumnos");
                Console.WriteLine("2- Menu Paises");
                Console.WriteLine("3- Salir");

                eleccion = Console.ReadLine();

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