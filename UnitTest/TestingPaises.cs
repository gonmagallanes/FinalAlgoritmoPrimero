namespace UnitTest;

using System.Security.Cryptography.X509Certificates;
using bussinessRule;

[TestClass]
public class TestingPaises
{
    [TestMethod]
    public void TestAgregarPais()
    {

        ListaPaises listaPaises = new ListaPaises();
        bool hayPais;

        listaPaises.agregarPais(new Paises("Argentina", "Buenos Aires", 54));
        hayPais = listaPaises.listaNoVaciaP();

        Assert.AreEqual(true, hayPais);
    }

    [TestMethod]
    public void TestEliminarPais()
    {

        ListaPaises listaPaises = new ListaPaises();
        bool hayPais;

        listaPaises.agregarPais(new Paises("Argentina", "Buenos Aires", 54));
        listaPaises.eliminarPais(54);
        hayPais = listaPaises.listaNoVaciaP();

        Assert.IsFalse(hayPais);
    }
    [TestMethod]
    public void TestBuscarPais()
    {

        ListaPaises listaPaises = new ListaPaises();

        listaPaises.agregarPais(new Paises("Argentina", "Buenos Aires", 54));
        listaPaises.agregarPais(new Paises("Bolivia", "La Paz", 12));

        string paisEliminado = listaPaises.buscarPais(54);

        Assert.AreEqual(paisEliminado, $"~~~~~\n Nombre: Argentina\n Capital: Buenos Aires\n Codigo de Area: 54\n~~~~~");
    }
}