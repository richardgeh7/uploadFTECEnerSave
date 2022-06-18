using ConsultasMVC.dbenersave;
using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC
{
    public class DescarteLixoStore : IDescarteLixoStore
    {

        private readonly DbEnerSaveContext _context;

        public DescarteLixoStore(DbEnerSaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DescarteLixoEntity>> GetAll()
        {
            var all = await _context.DescarteLixoContext.ToListAsync();
            all.ForEach(x => x.Usuario = _context.UsuarioContext.FirstOrDefault(c => c.Id == x.UsuarioId));

            return all;
        }
        public async Task<DescarteLixoEntity> GetById(int? id)
        {
            return await _context.DescarteLixoContext
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> Post(DescarteLixoViewModel model)
        {
            var gastosAgua = new DescarteLixoEntity();
            gastosAgua.Peso = model.Peso;
            gastosAgua.Organico = model.Organico;
            gastosAgua.Reciclavel = model.Reciclavel;
            gastosAgua.Eletronico = model.Eletronico;
            gastosAgua.Observacao = model.Observacao;
            gastosAgua.Periodo = model.Periodo;
            gastosAgua.UsuarioId = model.UsuarioId;
            _context.Add(gastosAgua);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> Update(DescarteLixoViewModel model)
        {
            try
            {
                var gastosAgua = new DescarteLixoEntity();
                gastosAgua.Id = model.Id;
                gastosAgua.Peso = model.Peso;
                gastosAgua.Organico = model.Organico;
                gastosAgua.Reciclavel = model.Reciclavel;
                gastosAgua.Eletronico = model.Eletronico;
                gastosAgua.Observacao = model.Observacao;
                gastosAgua.Periodo = model.Periodo;
                gastosAgua.UsuarioId = model.UsuarioId;

                _context.Update(gastosAgua);
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async Task<int> Delete(int id)
        {
            var tgastos = await _context.DescarteLixoContext.FindAsync(id);
            _context.DescarteLixoContext.Remove(tgastos);
            return await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.DescarteLixoContext.Any(e => e.Id == id);
        }
    }
}
