using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class ChampionsContext : DbContext
    {
        public ChampionsContext() : base("name=ChampionsContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ChampionsContext>());
        }
        public DbSet<Takim> Takimlar { get; set; }
        public DbSet<TakimRenk> TakimRenkler { get; set; }
        public DbSet<Renk> Renkler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Mac> Maclar { get; set; }

        //https://stackoverflow.com/questions/17127351/introducing-foreign-key-constraint-may-cause-cycles-or-multiple-cascade-paths
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
