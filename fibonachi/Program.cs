using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            long a=0;
            long b = 1;
            long c;
            Console.WriteLine("Do kog broja zelite da idete: ");
            int brojac = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            while (brojac >=0)
            {
              
                    Console.WriteLine(b);
                    c = a + b;
                    a = b;
                    b = c;
             
                brojac--;

            }
            Console.ReadKey();
        }
    }
}
