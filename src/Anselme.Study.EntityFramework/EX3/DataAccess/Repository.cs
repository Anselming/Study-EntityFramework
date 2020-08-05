using Anselme.Study.EntityFramework.DataAccess.SchoolContext.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anselme.Study.EntityFramework
{
    public class Repository<T> : DbContext
        where T : class
    {
        public Repository() : base("ApplicationContext") 
        {
            Database.SetInitializer<Repository<T>>(null);
        }

        public DbSet<T> Entity { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Add(new StrangePluralyzeConvention());
        }


    }
}
