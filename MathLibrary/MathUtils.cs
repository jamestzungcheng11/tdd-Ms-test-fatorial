using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
     public class MathUtils
    {
        public static long CalcularFatorial(int valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("nao e possivel calcular o valor do fatorial que sao menor de zero");
            }
            if (valor == 0)
                return 1;

            return valor * CalcularFatorial(valor - 1);
        }

    }

}
