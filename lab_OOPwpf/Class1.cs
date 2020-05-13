using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_OOPwpf
{
    class Class1
    {
        //มองให้เป็น สิ่งที่จับต้องได้
        private int _id;
        private string _name;
        private string _lastname;
        private string _postion;
        private string Fullname()
        {
            return Name + " " + Lastname;
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set {
                _id = value;
            }

        }

        //สืบทอดมาจากคลาสตัวใหญ่
        public Class1(int id, string name, string lastname, string position)         //สร้างคลาส//
        {
            ID = id;
            Name = name;
            Lastname = lastname;
            Postion = position;
        }
        public Class1(int id, string name, string lastname) : this()
        {
            ID = id;
            Name = name;
            Lastname = lastname;
         
        }
        public Class1()
        {
            ID = 0;
            Name = "ไม่ระบุ";
            Lastname = "ไม่ระบุ";
            Postion = "ไม่ระบุ";
        }


        public string Name { get => _name; set => _name = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string Postion { get => _postion; set => _postion = value; }




     
    }
}
