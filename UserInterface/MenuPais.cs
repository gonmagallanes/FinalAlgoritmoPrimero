using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using bussinessRule;

namespace UserInterface
{
    public class MenuPais
    {
        ListaPaises paisListado = new ListaPaises();

        public void mostrarMenuPaises()
        {
            string eleccionPais = "";
            do
            {
                Console.WriteLine("\n~~~ Menu Paises ~~~ \n");
                Console.WriteLine("1- Agregar País");
                Console.WriteLine("2- Eliminar País");
                Console.WriteLine("3- Modificar País");
                Console.WriteLine("4- Mostrar Paises");
                Console.WriteLine("5- Volver al inicio");


                eleccionPais = Console.ReadLine();

                switchPaises(eleccionPais);


            } while (eleccionPais != "5");

        }

        public void switchPaises(string eleccionPais)
        {
            switch (eleccionPais)
            {
                case "1":
                    menuAgregar();
                    break;
                case "2":
                    if (paisListado.listaNoVaciaP())
                    {
                        menuEliminarPais();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" \n \n No hay paises para eliminar \n \n ");
                    }
                    break;
                case "3":
                    if (paisListado.listaNoVaciaP())
                    {
                        menuModificarPais();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" \n \n No hay paises para modificar \n \n ");
                    }
                    break;
                case "4":
                    if (paisListado.listaNoVaciaP())
                    {
                        Console.WriteLine(paisListado.mostrarPaises());
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" \n \n No hay paises para mostrar \n \n ");
                    }
                    break;
                case "5":
                    Console.WriteLine("");
                    break;
            }
        }

        public void menuAgregar()
        {
            string nombrePais = "";
            string nombreCapital = "";
            int idPais;
            try
            {
                Console.WriteLine("Ingresar País: ");
                nombrePais = Console.ReadLine();

                Console.WriteLine("Ingresar Capital del País: ");
                nombreCapital = Console.ReadLine();

                Console.WriteLine("Ingresar codigo de area del Pais");
                idPais = int.Parse(Console.ReadLine());

                if (nombreCapital != "" && nombreCapital != "" && idPais >= 1)
                {
                    paisListado.agregarPais(new Paises(nombrePais, nombreCapital, idPais));
                }
                else
                {
                    Console.WriteLine("\n \n Se ingresaron mal los datos, por favor volver a ingresarlos. \n \n ");
                }
            }
            catch
            {
                Console.WriteLine("\n \n Se ingresaron mal los datos, por favor volver a ingresarlos. \n \n ");
            }
        }

        private void menuEliminarPais()
        {
            try
            {
                Console.WriteLine("Ingresar Codigo del pais a eliminar: ");
                int idPais = int.Parse(Console.ReadLine());

                if (paisListado.eliminarPais(idPais))
                {
                    paisListado.eliminarPais(idPais);
                    Console.WriteLine("\n \nPais ELIMINADO");
                }
                else
                {
                    Console.WriteLine("\n \n Se ingresaron mal los datos, por favor volver a ingresarlos. \n \n ");
                }
            }
            catch
            {
                Console.WriteLine("\n \n Se ingresaron mal los datos, por favor volver a ingresarlos. \n \n ");
            }
        }


        private void menuModificarPais()
        {
            try
            {
                string paisModificado = "";
                string capitalModificado = "";

                Console.WriteLine("Ingresar Codigo del pais a modificar: ");
                int idPais = int.Parse(Console.ReadLine());


                if (paisListado.eliminarPais(idPais))
                {
                    Console.WriteLine("Ingresar Pais: ");
                    paisModificado = Console.ReadLine();

                    Console.WriteLine("Ingresar su Capital");
                    capitalModificado = Console.ReadLine();

                    paisListado.modificarPais(idPais, paisModificado, capitalModificado);

                }
                else
                {
                    Console.WriteLine("\n \n Se ingresaron mal los datos, por favor volver a ingresarlos. \n \n ");
                }

            }
            catch
            {
                Console.WriteLine("\n \n Se ingresaron mal los datos, por favor volver a ingresarlos. \n \n ");
            }

        }

    }
}