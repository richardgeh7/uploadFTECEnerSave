using ConsultasMVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsultasMVC.dbenersave
{
    public partial class DbEnerSaveContext : DbContext
    {
        public DbEnerSaveContext()
        {
        }

        public DbEnerSaveContext(DbContextOptions<DbEnerSaveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GastosAguaEntity> GastosAguaContext { get; set; }

        public virtual DbSet<GastosEnergiaEntity> GastosEnergiaContext { get; set; }

        public virtual DbSet<DescarteLixoEntity> DescarteLixoContext { get; set; }

        public virtual DbSet<UsuarioEntity> UsuarioContext { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GastosAguaEntity>(entity =>
            {
                entity.ToTable("tgastos_agua", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.MetrosCubicos)
                    .HasColumnName("metros_cubicos");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usu_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.TgastosAgua)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("tgastos_agua_ibfk_1");
            });


            modelBuilder.Entity<GastosEnergiaEntity>(entity =>
            {
                entity.ToTable("tgastos_energia", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor");

                entity.Property(e => e.Kwh)
                    .HasColumnName("kwh");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usu_id");

                entity.HasOne(d => d.Usuario)
                   .WithMany(p => p.TgastosEnergia)
                   .HasForeignKey(d => d.UsuarioId)
                   .HasConstraintName("tgastos_energia_ibfk_1");
            });


            modelBuilder.Entity<DescarteLixoEntity>(entity =>
            {
                entity.ToTable("tdescarte_lixo", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Peso)
                    .HasColumnName("peso");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo");

                entity.Property(e => e.Reciclavel)
                    .HasColumnName("reciclavel");

                entity.Property(e => e.Organico)
                    .HasColumnName("organico");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usu_id");

                entity.HasOne(d => d.Usuario)
                   .WithMany(p => p.TdescarteLixo)
                   .HasForeignKey(d => d.UsuarioId)
                   .HasConstraintName("tdescarte_lixo_ibfk_1");

            });

            modelBuilder.Entity<UsuarioEntity>(entity =>
            {
                entity.ToTable("tusuarios", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasColumnName("login");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha");

                entity.Property(e => e.Nome)
                 .HasColumnName("nome");

                entity.Property(e => e.Administrador)
                 .HasColumnName("administrador");
                
            });
        }
    }
}
