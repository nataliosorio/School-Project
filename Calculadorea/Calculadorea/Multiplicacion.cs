using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadorea
{
    public class Multiplicacion
    {
        private int numero1;
        private int numero2;

        public Multiplicacion(int num1, int num2)
        {
            this.numero1 = num1;
            this.numero2 = num2;

        }

        public void Multiplicar()
        {
            var resultado = numero1 * numero2;
            Console.WriteLine($"La multiplicación entre {numero1} y {numero2} es: {resultado}");
        }
    }
}
