using System;

namespace ConsultasMVC.Entities
{
    public partial class GastosAguaEntity
    {
        public int Id { get; set; }
        public decimal MetrosCubicos { get; set; }
        public DateTime? Periodo { get; set; }

        public int UsuarioId { get; set; }

        public UsuarioEntity Usuario { get; set; }
    }
}
