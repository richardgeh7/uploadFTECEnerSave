﻿using System;

namespace EnerSave.Views.ViewModels
{
    public class DescarteLixoViewModel
    {
        public int Id { get; set; }
        public double Peso { get; set; }
        public int Reciclavel { get; set; }
        public int Organico { get; set; }
        public int Eletronico { get; set; }
        public string DescricaoLixo { get; set; }
        public DateTime? Periodo { get; set; }
        public long UsuarioId { get; set; }
    }
}