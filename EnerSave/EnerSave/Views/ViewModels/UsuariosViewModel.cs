using System;

namespace EnerSave.Views.ViewModels
{
    public class UsuariosViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int? Administrador { get; set; }
    }
}

