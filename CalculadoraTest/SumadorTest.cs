using Calculadora;
using Xunit;

namespace CalculadoraTest
{
    public class SumadorTest
    {
        [Fact]
        public void Sumador_ConValoresValidos_DevuelveSuma()
        {
            //Arrange
            Sumador sumador = new Sumador();
            int resultadoEsperado = 2;

            //Act
            int resultadoReal = sumador.sumar(1, 1);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        public void Sumador_ConMultiplesValoresValidos_DevuelveSuma(
            int a, int b, int resultadoEsperado
        )
        {
            //Arrange
            Sumador sumador = new Sumador();

            //Act
            int resultadoReal = sumador.sumar(a, b);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }
    }
}