using ConsultasMVC.dbenersave;
using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC
{
    public class GastosEnergiaStore : ITgastosEnergiaStore
    {

        private readonly DbEnerSaveContext _context;

        public GastosEnergiaStore(DbEnerSaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GastosEnergiaEntity>> GetAll()
        {
            return await _context.GastosEnergiaContext.ToListAsync();
        }
        public async Task<GastosEnergiaEntity> GetById(int? id)
        {
            return await _context.GastosEnergiaContext
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> Post(GastosEnergiaViewModel tgastosagua)
        {
            var gastosenergia = new GastosEnergiaEntity();
            gastosenergia.Kwh = tgastosagua.Kwh;
            gastosenergia.Valor = tgastosagua.Valor;
            gastosenergia.Periodo = tgastosagua.Periodo;
            gastosenergia.UsuarioId = tgastosagua.UsuarioId;
            _context.Add(gastosenergia);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> Update(GastosEnergiaEntity tgastos)
        {
            try
            {
                _context.Update(tgastos);
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async Task<int> Delete(int id)
        {
            var tgastos = await _context.GastosEnergiaContext.FindAsync(id);
            _context.GastosEnergiaContext.Remove(tgastos);
            return await _context.SaveChangesAsync();
        }
        public bool Exists(int id)
        {
            return _context.GastosEnergiaContext.Any(e => e.Id == id);
        }
    }
}
