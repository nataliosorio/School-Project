using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadorea
{
    public class Division
    {
        private int numero1;
        private int numero2;

        public Division(int num1, int num2)
        {
            this.numero1 = num1;
            this.numero2 = num2;

        }

        public void Dividir()
        {
            if (numero2 == 0)
            {
                Console.WriteLine("El numero divisor debe ser mayor a 0");
            }
            else
            {
                var resultado = (double)numero1 / numero2;
                Console.WriteLine($"La división entre {numero1} y {numero2} es: {resultado}");
            }
        }
    }
}
