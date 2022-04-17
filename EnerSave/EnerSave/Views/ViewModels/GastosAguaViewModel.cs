using System;

namespace EnerSave.Views.ViewModels
{
    public class GastosAguaViewModel
    {
        public int Id { get; set; }
        public double MetrosCubicos { get; set; }
        public DateTime? Periodo { get; set; }
        public long UsuarioId { get; set; }
    }
}
