using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Ket_noi_database.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Categorys> Categorys { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorys>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Categorys)
                .WillCascadeOnDelete(false);
        }
    }
}
