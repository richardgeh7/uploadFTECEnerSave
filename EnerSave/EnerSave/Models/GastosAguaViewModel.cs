using System;
using System.ComponentModel.DataAnnotations;


namespace EnerSave.Views.ViewModels
{
    public class GastosAguaViewModel
    {
       
        public int Id { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public decimal MetrosCubicos { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public DateTime? Periodo { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public int UsuarioId { get; set; }
    }
}
