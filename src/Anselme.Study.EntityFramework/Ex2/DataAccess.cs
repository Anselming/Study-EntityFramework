using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class DataAccess: DbContext
    {
        public DataAccess(): base("SchoolContext") 
        {
            Database.SetInitializer<DataAccess>(null);
        }

        public DbSet<Student> Student { get; set; }

    }
}
