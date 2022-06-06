using System;

namespace ConsultasMVC.dbenersave
{
    public partial class TdescarteLixo
    {
        public int Id { get; set; }
        public double Peso { get; set; }
        public int Reciclavel { get; set; }
        public int Organico { get; set; }
        public int Eletronico { get; set; }
        public string DescricaoLixo { get; set; }
        public DateTime? Periodo { get; set; }
        public int UsuarioId { get; set; }

        public Tusuarios Usuario { get; set; }
    }
}
