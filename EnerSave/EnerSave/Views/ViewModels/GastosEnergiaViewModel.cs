using ConsultasMVC.dbenersave;
using System;

namespace EnerSave.Views.ViewModels
{
    public class GastosEnergiaViewModel
    {
        public int Id { get; set; }
        public double Kilowatts { get; set; }
        public double Valor { get; set; }
        public DateTime? Periodo { get; set; }
        public int UsuarioId { get; set; }

        public Tusuarios Usuario { get; set; }
    }
}
