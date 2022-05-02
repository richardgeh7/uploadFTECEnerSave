using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC.Models
{
    public class TgastosEnergiaModel : ITgastosEnergiaModel
    {

        private readonly DbenersaveContext _context;

        public TgastosEnergiaModel(DbenersaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TgastosEnergia>> getAllGastosEnergia()
        {
            return await _context.TgastosEnergia.ToListAsync();
        }
        public async Task<TgastosEnergia> getGastosEnergiaById(int? id)
        {
            return await _context.TgastosEnergia
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> postGastosEnergia(GastosEnergiaViewModel tgastosEnergia)
        {
            var gastosEnergia = new TgastosEnergia();
            gastosEnergia.Kilowatts = tgastosEnergia.Kilowatts;
            gastosEnergia.Valor = tgastosEnergia.Valor;
            gastosEnergia.Periodo = tgastosEnergia.Periodo;
            gastosEnergia.UsuarioId = tgastosEnergia.UsuarioId;
            _context.Add(gastosEnergia);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> updateGastosEnergia(TgastosEnergia tgastosEnergia)
        {
            try
            {
                _context.Update(tgastosEnergia);
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async Task<int> deleteGastosEnergia(int id)
        {
            var tgastosEnergia = await _context.TgastosEnergia.FindAsync(id);
            _context.TgastosEnergia.Remove(tgastosEnergia);
            return await _context.SaveChangesAsync();
        }
        public bool gastosEnergiaExists(int id)
        {
            return _context.TgastosEnergia.Any(e => e.Id == id);
        }
    }
}
