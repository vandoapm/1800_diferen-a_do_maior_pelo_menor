using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1800_diferença_do_maior_pelo_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo da diferença do maior pelo menor");
            Console.WriteLine();

            Console.Write("Valor 1: ");
            float a = float.Parse(Console.ReadLine());
            
            Console.Write("Valor 2: ");
            float b = float.Parse(Console.ReadLine());



            if (a == b)
            {

                Console.WriteLine("Execute novamente e informe valores diferentes entre si");

            }
            else if (a > b)
            {

                Console.Write("Diferença de: "+a+" - "+b+" = ");Console.WriteLine(a - b);

            }
            else
            {

                Console.Write("Diferença de: " + b + " - " + a + " = "); Console.WriteLine(b - a);

            }
            
            Console.ReadLine();

        }
    }
}
