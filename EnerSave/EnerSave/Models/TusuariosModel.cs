using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC.Models
{
    public class TusuariosModel : ITusuariosModel
    {

        private readonly DbenersaveContext _context;

        public TusuariosModel(DbenersaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tusuarios>> getAllUsuarios()
        {
            return await _context.Tusuarios.ToListAsync();
        }
        public async Task<Tusuarios> getUsuariosById(int? id)
        {
            return await _context.Tusuarios
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> postUsuarios(UsuariosViewModel tusuarios)
        {
            var usuarios = new Tusuarios();
            usuarios.Nome = tusuarios.Nome;
            usuarios.Login = tusuarios.Login;
            usuarios.Senha = tusuarios.Senha;
            usuarios.Administrador = tusuarios.Administrador;
            _context.Add(usuarios);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> updateUsuarios(Tusuarios tusuarios)
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
        public async Task<int> deleteUsuarios(int id)
        {
            var tusuarios = await _context.Tusuarios.FindAsync(id);
            _context.Tusuarios.Remove(tusuarios);
            return await _context.SaveChangesAsync();
        }
        public bool usuariosExists(int id)
        {
            return _context.Tusuarios.Any(e => e.Id == id);
        }
    }
}
