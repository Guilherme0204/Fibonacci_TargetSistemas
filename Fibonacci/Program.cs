using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA = 0;
            int numB = 1;
            int fibonacci;
            for (int i = 0; i<20 ; i++) {


                fibonacci = numA + numB;
                Console.WriteLine($"Número que fazem parte da sequência de Fibonacci {fibonacci}"   );
                numA = numB; 
                numB = + fibonacci;
             
                

            }
            Console.ReadKey();
        }
    }
}
 