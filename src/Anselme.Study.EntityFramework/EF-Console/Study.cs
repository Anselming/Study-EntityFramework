using Anselme.Study.EntityFramework.DataAccess;
using Anselme.Study.EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anselme.Study.EntityFramework
{
    public class Study
    {
        static void Main(string[] args)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var students = context.Students; // Lazy Load

                foreach (Students student in students)
                    Console.WriteLine($"Student: {student.name}");

                Console.ReadKey();                
            }
        }
    }
}
