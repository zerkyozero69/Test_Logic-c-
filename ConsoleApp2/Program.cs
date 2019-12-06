 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    class Program
    {
        public static void Main(string[] args) 
        {
            genre();


            int people = 10;
            string weather = "nice";
            if (people <= 10 && weather == "nice")
            {
                Console.WriteLine("SaladMart");
                Console.WriteLine($"´ÍÅÅèÒ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Soup N Sandwich");
                Console.ReadKey();
            }

            /*-----------------------------------------------------------------------------------*/




            /*-----------------------------------------------------------*/
            double pepperLength = 4;

            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

            Console.WriteLine(message);
        }
        static void genre() 
        {
            string genre = Console.ReadLine();
            Console.WriteLine("Enter genre ");
            switch (genre)
            {
                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;
                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;
                case "Adventure":
                    Console.WriteLine("King Kong");
                    break;
                case "Horror":
                    Console.WriteLine("Psycho");
                    break;
                case "Science Fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;
                default:
                    Console.WriteLine("No movie found");
                    break;
            }
            Console.ReadLine();

        }
     
    }
}
