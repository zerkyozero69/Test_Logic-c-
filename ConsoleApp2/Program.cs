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
            Seconed();

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
            Console.WriteLine("Enter Genre");

            string genre = Console.ReadLine();




            Console.ReadLine();

            switch (genre)
            {
                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;
                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;

                case "Adventure":
                        Console.WriteLine("Monvie hit");
                        Console.WriteLine("King Kong");
                        break;
                    
                case "Horror":
                    Console.WriteLine("Psycho");
                    break;
                case "Science Fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;
                case "adventure":
                    Console.WriteLine("Monvie hit");
                    Console.WriteLine("King Kong");
                    break;
                default:
                    Console.WriteLine("No movie found");
                    break;
            }
            Proing proing;
            proing.Name = "leg";
            proing.Oid = Guid.NewGuid();
            proing.leg = Convert.ToInt16(2).ToString();
            Console.WriteLine(proing.Oid+" "+proing.Name+" "+proing.leg);
            Console.WriteLine();
             

           
            return ;
        
        }
        static void Seconed()
        {
            string myvalue = "myname";
            string myvalueanother = "hello";

            int number1 = 20;
            int number2 = 5;
            Console.WriteLine(myvalue+myvalueanother);
            myvalueanother = "test";
            Console.WriteLine(myvalueanother);
            Console.WriteLine(number1-number2+number1/number1);
            Console.ReadLine();
        }
        struct Proing
        {
            public Guid Oid ;
            public string Name;
            public string leg;
        }
    }

}
