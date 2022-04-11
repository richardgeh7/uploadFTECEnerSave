using Microsoft.EntityFrameworkCore;

namespace ConsultasMVC.dbenersave
{
    public partial class DbenersaveContext : DbContext
    {
        public DbenersaveContext()
        {
        }

        public DbenersaveContext(DbContextOptions<DbenersaveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TgastosAgua> TgastosAgua { get; set; }
        public virtual DbSet<TgastosEnergia> TgastosEnergia { get; set; }
        public virtual DbSet<TdescarteLixo> TdescarteLixo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=maplestory;database=dbenersave");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TgastosAgua>(entity =>
            {
                entity.ToTable("tgastos_agua", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(19)");
            });

            modelBuilder.Entity<TgastosEnergia>(entity =>
            {
                entity.ToTable("tgastos_energia", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(19)");

            });

            modelBuilder.Entity<TdescarteLixo>(entity =>
            {
                entity.ToTable("tdescarte_lixo", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(19)");
            });
        }
    }
}
