using EX6.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository r = new Repository();
            var market = r.Market;

            r.Market.Add(new Model.Market()
            {
                Name = "Eletronica",
                CommonCustomerSpecification = new Model.CustomerSpecification()
                {
                    Name = "Publico Y",
                    Percentage = 50,
                },
                Industries = new List<Model.Industry>()
                {
                    new Model.Industry(){ Description = "É?", MarketShare = 20 },
                    new Model.Industry(){ Description = "Í?", MarketShare = 30 },
                    new Model.Industry(){ Description = "Ó?", MarketShare = 40 },
                }
            });
            r.SaveChanges();

            foreach (var m in market)
            {
                Console.WriteLine(m.Name);
            }

            Console.ReadKey();
        }
    }
}
