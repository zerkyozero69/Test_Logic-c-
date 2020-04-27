using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_OOPwpf
{
    class Class1
    {
        private int _id;
        private string _name;
        private string _lastname;
        private string _postion;
        private string  Fullname()
        {
            return Name + " " + Lastname;
        }   
        public   int ID
        {
            get
            {
                return _id;
            }
            set  {
                _id = value;
                }

        }

        public string Name { get => _name; set => _name = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string Postion { get => _postion; set => _postion = value; }
    }
}
