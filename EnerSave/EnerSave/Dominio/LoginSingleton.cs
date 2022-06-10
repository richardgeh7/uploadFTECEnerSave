using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnerSave.Dominio
{

    public sealed class LoginSingleton
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public bool Logado { get; set; }

        public static LoginSingleton Instance { get; } = new LoginSingleton();

        private LoginSingleton() { }
    }
}
