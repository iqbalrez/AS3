using System.Data.Entity;

namespace SelfService
{
    public partial class ShirtModel : DbContext
    {
        public ShirtModel()
            : base("name=ShirtModel")
        {
        }

        public virtual DbSet<Shirts> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shirts>()
                .Property(e => e.size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Shirts>()
                .Property(e => e.price)
                .HasPrecision(19, 4);
        }
    }
}
