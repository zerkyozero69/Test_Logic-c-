using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowchart_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int trinum = 1;
            while (num > 0) 
            {
                Console.Write(trinum);
                trinum++;
                num--;
            }
   
            Console.WriteLine();
            return;
        }
    }
}
