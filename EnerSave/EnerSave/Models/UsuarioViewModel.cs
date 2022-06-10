using System;
using System.ComponentModel.DataAnnotations;


namespace EnerSave.Views.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Login { get; set; }
       
        [Required(AllowEmptyStrings = false)]
        public string Senha { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public int Administrador { get; set; }
    }
}
