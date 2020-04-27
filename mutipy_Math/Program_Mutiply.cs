using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutipy_Math
{
    class Program_Mutiply
    {
        static void Main(string[] args)
        {
            var number = "1";
            for (var i = 2; i <= 25; i++)
            {
                for (var j = 1; j <= 12; j++)
                {
                    Console.Write($"{i}x{j}={i * j},");
                }
                trymeta(number);
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
        static void  trymeta    ( string S)
            {
            S = $"inw mai";
     
            }
          

        
    }
}
