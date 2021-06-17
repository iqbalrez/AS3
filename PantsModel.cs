using System.Data.Entity;

namespace SelfService
{
    public partial class PantsModel : DbContext
    {
        public PantsModel()
            : base("name=PantsModel")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.size)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
