namespace Star_K.DBApi.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StarK_DB : DbContext
    {
        public StarK_DB()
            : base("name=StarKDB")
        {
        }

        public virtual DbSet<Logging> Loggings { get; set; }
        public virtual DbSet<UkdFile> UkdFiles { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }

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
