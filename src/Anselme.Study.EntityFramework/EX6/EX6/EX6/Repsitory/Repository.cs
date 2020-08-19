using EX6.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6.Repsitory
{
    public class Repository : DbContext
    {
        public Repository() : base("ApplicationContext")
        {
            Database.SetInitializer<Repository>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Industry>()
            //   .HasMany<Market>(m => m.Markets)
            //   .WithMany(i => i.Industries)
            //   .Map(cs =>
            //   {
            //       cs.MapLeftKey("MarketID");
            //       cs.MapRightKey("IndustryID");
            //       cs.ToTable("Market_Industry");
            //   });

            modelBuilder.Entity<Market>()
                .HasMany<Industry>(i => i.Industries)
                .WithMany(m => m.Markets)
                .Map(cs =>
                {
                    cs.MapLeftKey("MarketID");
                    cs.MapRightKey("IndustryID");
                    cs.ToTable("Market_Industry");
                });
        }

        public DbSet<Market> Market { get; set; }
        public DbSet<Industry> Industry { get; set; }

    }
}
