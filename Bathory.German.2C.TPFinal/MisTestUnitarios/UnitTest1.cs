using Entidades;
namespace MisTestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlIngresarNombreOApellido_SeEspera_IngresoDeLetras()
        {
            bool resultadoNombre = false;
            bool resultadoApellido = false;

            Cliente cliente = new Cliente();
            cliente.Nombre = "Juan";
            cliente.Apellido = "Perez";

            resultadoNombre = Validadora.ValidarString(cliente.Nombre);
            resultadoApellido = Validadora.ValidarString(cliente.Apellido);

            Assert.IsTrue(resultadoNombre);
            Assert.IsTrue(resultadoApellido);
        }

        [TestMethod]
        [ExpectedException(typeof(NumeroInvalidoException))]
        public void AlIngresarUnDniNegativoOFueraDeRango_SeEspera_UnError()
        {
            bool resultado = false;

            Cliente cliente = new Cliente();
            cliente.Dni = -90;

            resultado = Validadora.ValidarIntConMaxYMin(cliente.Dni.ToString(), 100000, 100000000);
        }
    }
}