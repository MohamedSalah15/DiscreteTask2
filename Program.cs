using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FST Num");
            int xo = int.Parse(Console.ReadLine());   
            Console.WriteLine("SCD Num");
            int ox = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int x=xo;x<=ox;x++)
            {
                sum = 0;
                for (int l = 1; l <= x / 2; l++)
                {
                    if (x % l == 0)
                        sum += l;              
                }
                if (sum == x)
                    Console.WriteLine( x + " Perfect Number");
            }





        }
    }
}
