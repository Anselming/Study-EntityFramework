using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anselme.Study.EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<StrangeEntity> r = new Repository<StrangeEntity>();
            var entity = r.Entity;

            foreach (var e in entity)
            {
                Console.WriteLine($"{e.Name}");
            }

            Console.WriteLine("Finish");
            Console.ReadKey();
        }
    }
}
