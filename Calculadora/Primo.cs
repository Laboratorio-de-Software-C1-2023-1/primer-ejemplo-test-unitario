using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Primo
    {
        public bool EsPrimo(int numero)
        {
            if (numero == 1)
            {
                return false;
            }

            this.EsMayorA1000(numero);

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void EsMayorA1000(int numero)
        {
            if (numero > 1000)
            {
                throw new ArgumentException("No se permite calcular numeros mayores a 1000");
            }
        }
    }
}
