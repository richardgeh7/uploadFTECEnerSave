using ConsultasMVC.dbenersave;
using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC
{
    public class UsuarioStore : IUsuarioStore
    {

        private readonly DbEnerSaveContext _context;

        public UsuarioStore(DbEnerSaveContext context)
        {
            _context = context;
        }

        Task<UsuarioEntity> IUsuarioStore.GetById(int? id)
        {
            return _context.UsuarioContext
                .FirstOrDefaultAsync(m => m.Id == id.Value);
        }

        public async Task<UsuarioEntity> GetByLogin(string login)
        {
            return await _context.UsuarioContext
                .FirstOrDefaultAsync(m => m.Login == login);
        }

        public async Task<int> Post(UsuarioViewModel model)
        {
            var entity = new UsuarioEntity();
            entity.Login = model.Login;
            entity.Nome = model.Nome;
            entity.Senha = model.Senha;
            entity.Administrador = model.Administrador;

            _context.Add(entity);
            
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> LoginAsync(string login, string senha)
        {
            return _context.UsuarioContext.Any(m => m.Login == login && m.Senha == senha);
        }

        public List<UsuarioEntity> GetUsuarios()
        {
            return _context.UsuarioContext.ToList();
        }

        public async Task<int> Delete(int id)
        {
            var tusuario = await _context.UsuarioContext.FindAsync(id);
            _context.UsuarioContext.Remove(tusuario);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<UsuarioEntity>> GetAll()
        {
            return await _context.UsuarioContext.ToListAsync();
        }

        public bool Exists(int id)
        {
            return _context.UsuarioContext.Any(e => e.Id == id);
        }

        public async Task<int> Update(UsuarioViewModel tusuarios)
        {
            try
            {
                _context.Update(tusuarios);
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
