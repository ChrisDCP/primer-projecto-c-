using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i;
            Console.WriteLine("escriba el primer numero");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("escriba el segundo numero");
            n = int.Parse(Console.ReadLine());

            for (i = m; i <= n; i++)

            {
                if (i % 2 == 0)

                    Console.WriteLine(i);

            }

            Console.ReadKey();
        }
    }
}
