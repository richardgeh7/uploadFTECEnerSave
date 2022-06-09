using System;
using System.ComponentModel.DataAnnotations;

namespace EnerSave.Views.ViewModels
{
    public class DescarteLixoViewModel
    {
        public int Id { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public decimal Peso { get; set; }
       
        [Required(AllowEmptyStrings = false)]
        public DateTime? Periodo { get; set; }
        
        public bool Organico { get; set; }
        
        public bool Reciclavel { get; set; }
        
        public bool Eletronico { get; set; }
        
        public string Observacao { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int UsuarioId { get; set; }
    }
}
