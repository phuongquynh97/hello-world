namespace LoginMau.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class quynh : DbContext
    {
        public quynh()
            : base("name=quynh")
        {
        }

        public virtual DbSet<Userr> Userrs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Userr>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Userr>()
                .Property(e => e.pw)
                .IsUnicode(false);
        }
    }
}
