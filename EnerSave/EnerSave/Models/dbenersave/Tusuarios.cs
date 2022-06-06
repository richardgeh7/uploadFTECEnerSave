using System.Collections.Generic;

namespace ConsultasMVC.dbenersave
{
    public partial class Tusuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int? Administrador { get; set; }

        public ICollection<TgastosAgua> TgastosAgua { get; set; }

        public ICollection<TgastosEnergia> TgastosEnergia{ get; set; }

        public ICollection<TdescarteLixo> TdescarteLixo { get; set; }
    }
}
