using ConsultasMVC.dbenersave;
using System;

namespace EnerSave.Views.ViewModels
{
    public class GastosAguaViewModel
    {
        public int Id { get; set; }
        public double MetrosCubicos { get; set; }
        public DateTime? Periodo { get; set; }
        public int UsuarioId { get; set; }

        public Tusuarios Usuario { get; set; }
    }
}
