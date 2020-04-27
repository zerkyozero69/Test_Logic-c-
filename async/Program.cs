using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static async.Class1;

namespace Console2
{
    class Product
    {
        public string username { get; set; }
        public string password { get; set; }
        public string TransactionId { get; set; }
        public string Type { get; set; }
        public string OutletCode { get; set; }
        public string Class { get; set; }
        public string Subclass { get; set; }
        public string DocDate { get; set; }
    }

    class ResultProduct
    {
        public string ResultCode { get; set; }
        public string ResultDesc { get; set; }
        public string ApplicationNo { get; set; }
        public string DocumentType { get; set; }
        public string debitnote { get; set; }
        public string dfbookno { get; set; }
        public string dfcdno { get; set; }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get;set;}
        public int Age { get; set; }
            
        }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }

    class Program
    {

        public static void Main(string[] args)
        {

            try
            {
                Inner_class inner = new Inner_class();
                
                int iterations = 1;
                double result = Calculater(iterations);
                linQc();
                Console.ReadKey();
                Console.WriteLine(result);
                Console.ReadLine();
                // throw new Exception("E1");

            }
            catch (Exception ex) when (log(ex, "error"))
            {
                Console.WriteLine(ex);

            }

        }

        static async Task RunAsync()
        {
            string result = await MakePost();
            Console.WriteLine("Result is " + result);
            Console.WriteLine("---RunAsync end---");
        }

        static async Task<string> MakePost()
        {
            HttpClient client = new HttpClient();

            Console.WriteLine("RunAsync");
      
            Product product = new Product();
            product.Class = "myUser";
            product.password = "myPassword";

            string url = "http://me.react.com/";

            Console.WriteLine("RunAsync - url: " + url + product);
            //var response = await client.PostAsync(url, content);
            var response = await client.PostAsJsonAsync(url, product);

            response.EnsureSuccessStatusCode();
            //return response.Headers.Location;

            var responseString = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(responseString);

            ResultProduct result = JsonConvert.DeserializeObject<ResultProduct>(responseString);

            Console.WriteLine("---Task end---");
            Console.ReadLine();
            return responseString;


        }
        static double Calculater(int iterations)
        {
            int incircle = 0;
            var random = new Random();
            for (int i = 0; i < iterations; i++)
            {
                var a = random.NextDouble();
                var b = random.NextDouble();
                var c = Math.Sqrt(a * a + b * b);
                if (c <= 1)
                {
                    incircle++;
                }
            }
            Console.WriteLine(iterations);
            return ((double)incircle / iterations) * 4;

        }
        static bool log(Exception ex, string message, params object[] args)
        {
            Console.WriteLine(message, args);
            return false;
        }
        static void linQc()
        {
            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18} ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18  } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
};

            //        IList<Standard> standardList = new List<Standard>() {
            //new Standard(){ StandardID = 1, StandardName="Standard 1"},
            //new Standard(){ StandardID = 2, StandardName="Standard 2"},
            //new Standard(){ StandardID = 3, StandardName="Standard 3"}

            foreach (Student row in studentList)
            {
                var studentNames = studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Select(s => s.StudentName);

                Console.WriteLine(studentNames);


            }
        }


        public class Inner_class
        {

            // Static method of Inner class 
            public static void method1()
            {

                // Displaying the value of a 
                // static member of the outer class 
                Console.WriteLine("Outer_class.str");
            }

        }
        public string Happy_song() 
        {
            Car cars = new Car();
            cars.Brand = "Toyota";
            cars.Model ="veost" ;

            return "cars";
                
        }
    }


}
        

   