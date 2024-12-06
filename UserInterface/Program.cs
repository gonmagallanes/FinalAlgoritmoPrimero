namespace UserInterface;
using bussinessRule;

class Program
{
    static void Main(string[] args)
    {

        ControladorMenus elegirMenu = new ControladorMenus();
        elegirMenu.elegirMenus();

    }
}


// --- Si se borra el pais, que salte desconocido.
// --- Que no se repita el ID, ni capital, ni nombre.
// --- ADVERTENCIA DE FALTA DE PAIS HACIA EL ALUMNO.