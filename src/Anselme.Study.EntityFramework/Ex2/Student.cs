using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"id = {id}\tname = {name}";
        }
    }
}
