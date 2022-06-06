using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers.abstractions
{
    public interface ITusuariosModel
    {
        Task<IEnumerable<Tusuarios>> getAllUsuarios();
        Task<Tusuarios> getUsuariosById(int? id);
        Task<int> postUsuarios(UsuariosViewModel tusuarios);
        Task<int> updateUsuarios(Tusuarios tusuarios);
        Task<int> deleteUsuarios(int id);
        bool usuariosExists(int id);
    }
}

