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
        public DbSet<Renk> Renkler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Mac> Maclar { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

        #region MyRegion

        //https://stackoverflow.com/questions/17127351/introducing-foreign-key-constraint-may-cause-cycles-or-multiple-cascade-paths
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //}

        // https://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx

        #endregion