namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QcdsDbContext : DbContext
    {
        public QcdsDbContext()
            : base("name=Qcds")
        {
        }

        public virtual DbSet<QcdsIT> QcdsITs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QcdsIT>()
                .Property(e => e.Khoi)
                .IsFixedLength();
        }
    }
}
