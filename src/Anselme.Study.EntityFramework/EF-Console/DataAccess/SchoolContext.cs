using Anselme.Study.EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anselme.Study.EntityFramework.DataAccess
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext") { }

        public DbSet<Students> Students { get; set; }

    }
}
