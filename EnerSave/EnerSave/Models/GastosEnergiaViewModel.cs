using System;
using System.ComponentModel.DataAnnotations;

namespace EnerSave.Views.ViewModels
{
    public class GastosEnergiaViewModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public decimal Kwh { get; set; }

        [Required(AllowEmptyStrings = false)]
        public decimal Valor { get; set; }

        [Required(AllowEmptyStrings = false)]
        public DateTime? Periodo { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public int UsuarioId { get; set; }
    }
}
