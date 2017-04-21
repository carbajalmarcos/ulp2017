using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc C = new Calc();
            C.setOperacion = delegate (int a, int b) {
                Console.WriteLine(a+b);
                return a + b;
            };
            C.setOperacion += (a, b) => {
                Console.WriteLine(a - b);
                return a -b;
            };

           C.setOperacion(2,3);
           Console.ReadLine();
           
        }

    }
}
