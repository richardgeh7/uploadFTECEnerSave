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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=maplestory1;database=dbenersave");
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

                entity.Property(e => e.MetrosCubicos)
                    .HasColumnName("metros_cubicos")
                    .HasColumnType("decimal(19,8)");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo")
                    .HasColumnType("date");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usu_id")
                    .HasColumnType("int(19)");
            });
        }
    }
}
