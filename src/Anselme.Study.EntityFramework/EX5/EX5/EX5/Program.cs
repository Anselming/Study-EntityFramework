using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository r = new Repository();

            #region C - Create

            r.Mercado.Add(new Model.Mercado()
            {
                Nome = "Extra",
                DataDoInicioDeOperacao = DateTime.Now,
                EmOperacao = true,
                Detalhes = "",
            });
            r.SaveChanges();

            #endregion

            #region R- Read

            var mercados = r.Mercado;
            foreach (var m in mercados)
            {
                Console.WriteLine(m.Nome);
            }

            #endregion

            #region U - Update

            var mercado = r.Mercado.Where(m => m.Nome == "Extra").FirstOrDefault();
            mercado.Nome = "Supermercado Extra";
            r.Mercado.AddOrUpdate(mercado);
            r.SaveChanges();

            #endregion

            #region D - Delete

            var mercadoDelete = r.Mercado.Where(m => m.Nome == "Supermercado Extra").FirstOrDefault();
            r.Mercado.Remove(mercadoDelete);
            r.SaveChanges();

            #endregion


            Console.ReadKey();
        }

    }
}
