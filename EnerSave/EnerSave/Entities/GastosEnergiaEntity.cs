using Newtonsoft.Json;
using System;

namespace ConsultasMVC.Entities
{
    public partial class GastosEnergiaEntity
    {
        public int Id { get; set; }
        
        public decimal Valor { get; set; }

        public decimal Kwh { get; set; }
        
        public DateTime? Periodo { get; set; }
        
        public int UsuarioId { get; set; }
        [JsonIgnore]

        public virtual UsuarioEntity Usuario { get; set; }
    }
}
