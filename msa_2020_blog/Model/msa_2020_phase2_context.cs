using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace msa_2020_blog.Model
{
    public partial class msa_2020_phase2_context : DbContext
    {
        public msa_2020_phase2_context()
        {
        }

        public msa_2020_phase2_context(DbContextOptions<msa_2020_phase2_context> options)
            : base(options)
        {
        }

        public virtual DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:msa2020sw.database.windows.net,1433;Initial Catalog=blog;Persist Security Info=False;User ID=swang;Password=420DankMemes;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.Content).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
