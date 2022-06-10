using ConsultasMVC.dbenersave;
using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC
{
    public interface IUsuarioStore 
    {
        Task<UsuarioEntity> GetById(int? id);
        Task<UsuarioEntity> GetByLogin(string login);
        Task<int> Post(UsuarioViewModel model);
        Task<bool> LoginAsync(string login, string senha);
        List<UsuarioEntity> GetUsuarios();
        Task<int> Delete(int id);
        Task<List<UsuarioEntity>> GetAll();
        bool Exists(int id);
        Task<int> Update(UsuarioViewModel tusuarios);
    }
}
