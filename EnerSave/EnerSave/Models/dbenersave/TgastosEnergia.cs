﻿using System;

namespace ConsultasMVC.dbenersave
{
    public partial class TgastosEnergia
    {
        public int Id { get; set; }
        public double Kilowatts { get; set; }
        public double Valor { get; set; }
        public DateTime? Periodo { get; set; }
        public long UsuarioId { get; set; }
    }
}