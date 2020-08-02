using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess da = new DataAccess();
            var students = da.Student;

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }


        }
    }
}
