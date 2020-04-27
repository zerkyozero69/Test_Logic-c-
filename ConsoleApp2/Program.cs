 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    class Program
    {
        //static void Multplyleg(Proing proing)
        //{
        //    proing.leg = proing.leg * 10;
         
        //    Console.WriteLine("method internal =A "  + " Õ“¬ÿ" + proing.leg);
        //    Console.WriteLine("method internal =A "  + " Õ“¬ÿ" + proing.leg);
        //}
        //public static void Main(string[] args) 
        //{
        //    int[] arrylove = new int[5];
        //    arrylove[2] =2;
        //    arrylove[0] = 1;
        //    int[,] intarry = { { 1, 2, 3 }, { 5, 6, 7 } };
        //    //int firsttestarray = intarry[1][2];
        //    genre();
        //    Seconed();
        
        //    int people = 10;
        //    string weather = "nice";
        //    if (people <= 10 && weather == "nice")
        //    {
        //        Console.WriteLine("SaladMart");
        //        Console.WriteLine($"¥Õ≈≈Ë“");
        //        Console.ReadKey();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Soup N Sandwich");
        //        Console.ReadKey();
        //    }

        //    /*-----------------------------------------------------------------------------------*/




        //    /*-----------------------------------------------------------*/
        //    double pepperLength = 4;

        //    string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

        //    Console.WriteLine(message);
        //}
        //static void genre()
        //{
        //    Console.WriteLine("Enter Genre");

        //    string genre = Console.ReadLine();




        //    Console.ReadLine();

        //    switch (genre)
        //    {
        //        case "Drama":
        //            Console.WriteLine("Citizen Kane");
        //            break;
        //        case "Comedy":
        //            Console.WriteLine("Duck Soup");
        //            break;

        //        case "Adventure":
        //                Console.WriteLine("Monvie hit");
        //                Console.WriteLine("King Kong");
        //                break;
                    
        //        case "Horror":
        //            Console.WriteLine("Psycho");
        //            break;
        //        case "Science Fiction":
        //            Console.WriteLine("2001: A Space Odyssey");
        //            break;
        //        case "adventure":
        //            Console.WriteLine("Monvie hit");
        //            Console.WriteLine("King Kong");
        //            break;
        //        default:
        //            Console.WriteLine("No movie found");
        //            break;
        //    }
        //    Proing proing;
        //    proing.Name = "legµŸÎ"+""+"Õ‘Õ‘";
        //    proing.Oid = Guid.NewGuid();
        //    proing.leg = 2;
        //    int legconvert = 0;
        //    bool status = Int32.TryParse("one",out legconvert);
        //    Console.WriteLine(proing.Oid+" "+proing.Name+" "+proing.leg+legconvert);
        //    Console.WriteLine();

        static void Main(string[] args)
        {
            //console.writeline("hello word");
            //console.readline();

            human2 man1 = new human2();
                man1.addage();
                man1.setName("ÀŸ°√–®—ß");
                man1.setLastname("ohoho  ");

            human2 man2 = new human2();
            man2.setName("aa");
            man2.setLastname("c");
            string human1 = man1.getName();
                Console.WriteLine(human1);
            Console.WriteLine(man2.getName());
                Console.ReadLine();
          

         //   return ;
        
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
            public int leg;
        }
        class Proingclass   
        {
            public Guid Oid;
            public int Name;
            public string leg;
        }
    }


}
