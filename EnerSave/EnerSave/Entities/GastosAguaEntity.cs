using Newtonsoft.Json;
using System;

namespace ConsultasMVC.Entities
{
    public partial class GastosAguaEntity
    {
        public int Id { get; set; }
        public decimal MetrosCubicos { get; set; }
        public DateTime? Periodo { get; set; }

        public int UsuarioId { get; set; }
        [JsonIgnore]

        public virtual UsuarioEntity Usuario { get; set; }
    }
}
