using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC.Models
{
    public class TgastosAguaModel : ITgastosAguaModel
    {

        private readonly DbenersaveContext _context;

        public TgastosAguaModel(DbenersaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TgastosAgua>> getAllGastosAgua()
        {
            return await _context.TgastosAgua.ToListAsync();
        }
        public async Task<TgastosAgua> getGastosAguaById(int? id)
        {
            return await _context.TgastosAgua
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> postGastosAgua(GastosAguaViewModel tgastosagua)
        {
            var gastosAgua = new TgastosAgua();
            gastosAgua.MetrosCubicos = tgastosagua.MetrosCubicos;
            gastosAgua.Periodo = tgastosagua.Periodo;
            gastosAgua.UsuarioId = tgastosagua.UsuarioId;
            _context.Add(gastosAgua);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> updateGastosAgua(TgastosAgua tgastosAgua)
        {
            try
            {
                _context.Update(tgastosAgua);
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async Task<int> deleteGastosAgua(int id)
        {
            var tgastosAgua = await _context.TgastosAgua.FindAsync(id);
            _context.TgastosAgua.Remove(tgastosAgua);
            return await _context.SaveChangesAsync();
        }
        public bool gastosAguaExists(int id)
        {
            return _context.TgastosAgua.Any(e => e.Id == id);
        }
    }
}
