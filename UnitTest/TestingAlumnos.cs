using bussinessRule;

namespace UnitTest
{
    [TestClass]
    public class TestingAlumnos
    {
        [TestMethod]
        public void TestAgregarAlumno()
        {
            ListaPaises testingPaises = new ListaPaises();
            ListaAlumno testingAlumno = new ListaAlumno(testingPaises);
            testingPaises.agregarPais(new Paises("Argentina", "Buenos Aires", 54));
            bool hayAlumnos;

            testingAlumno.agregarAlumno(new Alumno("Gon", 1, 10, 54));
            testingAlumno.agregarAlumno(new Alumno("Lu", 2, 9, 54));
            hayAlumnos = testingAlumno.listaNoVaciaA();

            Assert.IsTrue(hayAlumnos);

        }
        [TestMethod]
        public void TestEliminarAlumno()
        {
            ListaPaises testingPaises = new ListaPaises();
            ListaAlumno testingAlumno = new ListaAlumno(testingPaises);
            testingPaises.agregarPais(new Paises("Argentina", "Buenos Aires", 54));
            bool hayAlumnos;

            testingAlumno.agregarAlumno(new Alumno("Gon", 1, 10, 54));
            testingAlumno.eliminarAlumno(1);
            hayAlumnos = testingAlumno.listaNoVaciaA();

            Assert.AreEqual(hayAlumnos, false);

        }
        [TestMethod]
        public void TestPromedio()
        {
            ListaPaises testingPaises = new ListaPaises();
            ListaAlumno testingAlumno = new ListaAlumno(testingPaises);
            testingPaises.agregarPais(new Paises("Argentina", "Buenos Aires", 54));

            testingAlumno.agregarAlumno(new Alumno("Gon", 1, 10, 54));
            testingAlumno.agregarAlumno(new Alumno("Lu", 2, 10, 54));

            double promedio;

            promedio = testingAlumno.promedioGeneral();

            Assert.AreEqual(promedio, 10);
        }
        [TestMethod]
        public void TestNotaAlta()
        {
            ListaPaises testingPaises = new ListaPaises();
            ListaAlumno testingAlumno = new ListaAlumno(testingPaises);
            testingPaises.agregarPais(new Paises("Argentina", "Buenos Aires", 54));

            testingAlumno.agregarAlumno(new Alumno("Gon", 1, 10, 54));
            testingAlumno.agregarAlumno(new Alumno("Lu", 2, 9, 54));

            string mejorAlumno = testingAlumno.notaMasAlta();

            Assert.AreEqual(mejorAlumno, "Gon es el mejor alumno, con una nota de: 10");
        }

    }
}



