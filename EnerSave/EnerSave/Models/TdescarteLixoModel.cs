using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC.Models
{
    public class TdescarteLixoModel : ITdescarteLixoModel
    {

        private readonly DbenersaveContext _context;

        public TdescarteLixoModel(DbenersaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tusuarios>> getUsuarios()
        {
            return await _context.Tusuarios.ToListAsync();
        }

        public async Task<IEnumerable<TdescarteLixo>> getAllDescarteLixo()
        {
            var enersaveContext = _context.TdescarteLixo.Include(t => t.Usuario);
            return await enersaveContext.ToListAsync();
        }
        public async Task<TdescarteLixo> getDescarteLixoById(int? id)
        {
            return await _context.TdescarteLixo
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> postDescarteLixo(DescarteLixoViewModel tdescarteLixo)
        {
            var descarteLixo = new TdescarteLixo();
            descarteLixo.Peso = tdescarteLixo.Peso;
            descarteLixo.Reciclavel = tdescarteLixo.Reciclavel;
            descarteLixo.Organico = tdescarteLixo.Organico;
            descarteLixo.Eletronico = tdescarteLixo.Eletronico;
            descarteLixo.DescricaoLixo = tdescarteLixo.DescricaoLixo;
            descarteLixo.Periodo = tdescarteLixo.Periodo;
            descarteLixo.UsuarioId = tdescarteLixo.UsuarioId;
            descarteLixo.Usuario = tdescarteLixo.Usuario;
            _context.Add(descarteLixo);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> updateDescarteLixo(TdescarteLixo tdescarteLixo)
        {
            try
            {
                _context.Update(tdescarteLixo);
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async Task<int> deleteDescarteLixo(int id)
        {
            var tdescarteLixo = await _context.TdescarteLixo.FindAsync(id);
            _context.TdescarteLixo.Remove(tdescarteLixo);
            return await _context.SaveChangesAsync();
        }
        public bool descarteLixoExists(int id)
        {
            return _context.TdescarteLixo.Any(e => e.Id == id);
        }
    }
}
