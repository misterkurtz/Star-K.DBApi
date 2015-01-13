namespace Star_K.DBApi.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DBApi.Model;




    public partial class Star_KContext : DbContext
    {
        public Star_KContext()
            : base("name=StarK")
        {
        }

        public virtual DbSet<Logging> Loggings { get; set; }
        public virtual DbSet<UkdFile> UkdFiles { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UkdFile>()
                .Property(e => e.Bytes)
                .IsUnicode(false);

            modelBuilder.Entity<Visit>()
                .Property(e => e.VisitType)
                .IsUnicode(false);

            modelBuilder.Entity<Visit>()
                .Property(e => e.VisitComment)
                .IsUnicode(false);



        }

        
    }
}
