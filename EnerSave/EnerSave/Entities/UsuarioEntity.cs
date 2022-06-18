using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultasMVC.Entities
{
    public partial class UsuarioEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Nome { get; set; }

        public bool Administrador { get; set; }


        public virtual ICollection<GastosAguaEntity> TgastosAgua { get; set; }
        public virtual ICollection<GastosEnergiaEntity> TgastosEnergia { get; set; }
        public virtual ICollection<DescarteLixoEntity> TdescarteLixo { get; set; }
    }
}
