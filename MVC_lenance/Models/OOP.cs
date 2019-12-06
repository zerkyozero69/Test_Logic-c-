using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_learn.Models
{
    public class OOP
    {
        class human
        {
            public string name;
            public int age;
            public string sex;
            public string hihuman()
            {
                name = "สิริ";
                age = 52;
                return name +age+"hello";
            }
        }
    }
}