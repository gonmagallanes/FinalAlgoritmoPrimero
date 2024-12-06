using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bussinessRule
{
    public class ListaPaises
    {
        private List<Paises> _ListaPaises = new List<Paises>();

        public bool paisExistente(int id)
        {

            foreach (Paises pais in _ListaPaises)
            {

                if (pais.codigoDeArea == id)
                {
                    return true;
                }

            }

            return false;

        }

        public bool agregarPais(Paises paises)
        {
            if (paisExistente(paises.codigoDeArea))
            {
                return false;
            }
            else
            {
                _ListaPaises.Add(paises);
                return true;
            }
        }

        public bool eliminarPais(int id)
        {

            Paises eliminar;

            foreach (Paises pais in _ListaPaises)
            {

                if (pais.codigoDeArea == id)
                {

                    eliminar = pais;
                    _ListaPaises.Remove(pais);
                    return true;

                }

            }

            return false;

        }

        public bool modificarPais(int id, string nombrePais, string nombreCapital)
        {

            foreach (Paises pais in _ListaPaises)
            {
                if (pais.codigoDeArea == id)
                {
                    pais.nombrePais = nombrePais;
                    pais.nombreCapital = nombreCapital;

                    return true;
                }
            }

            return false;

        }

        public string buscarPais(int id)
        {
            string paisBuscado = "";

            foreach (Paises pais in _ListaPaises)
            {
                if (pais.codigoDeArea == id)
                {
                    paisBuscado = pais.nombrePais;

                }
            }
            return paisBuscado;
        }

        public string mostrarPaises()
        {
            string texto = "";

            foreach (Paises pais in _ListaPaises)
            {

                texto += "~~~~~ \n";

                texto += "País: " + pais.nombrePais + "\n";
                texto += "Capital: " + pais.nombreCapital + "\n";
                texto += "Codigo de Area: " + pais.codigoDeArea + "\n";


            }

            return texto;
        }

        public string pasarCodigoAPaises(int id)
        {

            foreach (Paises idPais in _ListaPaises)
            {

                if (idPais.codigoDeArea == id)
                {
                    return $"{idPais.nombrePais}";
                }

            }
            return "Desconocido";

        }

        // public string buscarPaises(int codigoArea)
        // {
        //     foreach (Paises pais in _ListaPaises)
        //     {
        //         if (pais.codigoDeArea == codigoArea)
        //         {
        //             return $"{pais.nombrePais}";
        //         }
        //     }
        //     return "";
        // }

        public bool listaNoVaciaP()
        {
            if (_ListaPaises.Count >= 0)
            {
                return true;
            }

            return false;

        }
    }
}