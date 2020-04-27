using Hello_world_json;
using System;

namespace Hello_world_json2
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //console.writeline("hello word");
            //console.readline();
            human2 man1 = new human2();
            man1.addage();
            man1.setName("หูกระจัง");
            man1.setName("ohoho  ");
            string human1 = man1.getName();
            Console.WriteLine(human1);
            Console.ReadLine();
        }
    }
}