using ConsultasMVC.dbenersave;
using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC
{
    public class GastosAguaStore : ITgastosAguaStore
    {

        private readonly DbEnerSaveContext _context;

        public GastosAguaStore(DbEnerSaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GastosAguaEntity>> GetAll()
        {
            return await _context.GastosAguaContext.ToListAsync();
        }
        public async Task<GastosAguaEntity> GetById(int? id)
        {
            return await _context.GastosAguaContext
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> Post(GastosAguaViewModel tgastosagua)
        {
            var gastosAgua = new GastosAguaEntity();
            gastosAgua.MetrosCubicos = tgastosagua.MetrosCubicos;
            gastosAgua.Periodo = tgastosagua.Periodo;
            gastosAgua.UsuarioId = tgastosagua.UsuarioId;
            _context.Add(gastosAgua);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> Update(GastosAguaEntity tgastosAgua)
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
        public async Task<int> Delete(int id)
        {
            var tgastosAgua = await _context.GastosAguaContext.FindAsync(id);
            _context.GastosAguaContext.Remove(tgastosAgua);
            return await _context.SaveChangesAsync();
        }
        public bool Exists(int id)
        {
            return _context.GastosAguaContext.Any(e => e.Id == id);
        }
    }
}
