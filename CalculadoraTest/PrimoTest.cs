using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculadoraTest
{
    public class PrimoTest
    {

        [Fact]
        public void Primo_ConValorNoPrimo_DevuelveNoEsPrimo()
        {
            //Arrange
            Primo primo = new Primo();
            bool resultadoEsperado = false;

            //Act
            bool resultadoReal = primo.EsPrimo(4);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        [Fact]
        public void Primo_ConValorUno_DevuelveNoEsPrimo()
        {
            //Arrange
            Primo primo = new Primo();
            bool resultadoEsperado = false;

            //Act
            bool resultadoReal = primo.EsPrimo(1);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        [Fact]
        public void Primo_ConValorDos_DevuelveEsPrimo()
        {
            //Arrange
            Primo primo = new Primo();
            bool resultadoEsperado = true;

            //Act
            bool resultadoReal = primo.EsPrimo(2);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }



        [Fact]
        public void Primo_ConValorPrimo_DevuelveEsPrimo()
        {
            //Arrange
            Primo primo = new Primo();
            bool resultadoEsperado = true;

            //Act
            bool resultadoReal = primo.EsPrimo(7);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }


        [Fact]
        public void Primo_ConValorInvalido_ArrojaException()
        {
            //Arrange
            Primo primo = new Primo();

            //Act & Assert
            try
            {
                bool resultadoReal = primo.EsPrimo(1001);
            } catch (ArgumentException ex)
            {
                Assert.Equal("No se permite calcular numeros mayores a 1000", ex.Message);
                return;
            }

            Assert.True(false, "No devolvió excepción esperada");
        }

    }
}
