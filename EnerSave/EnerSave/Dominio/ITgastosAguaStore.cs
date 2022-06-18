using ConsultasMVC.dbenersave;
using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC
{
    public interface ITgastosAguaStore
    {
        Task<IEnumerable<GastosAguaEntity>> GetAll();
        Task<GastosAguaEntity> GetById(int? id);
        Task<int> Post(GastosAguaViewModel model);
        Task<int> Update(GastosAguaEntity model);
        Task<int> Delete(int id);
        bool Exists(int id);
        Task<IEnumerable<GastosAguaEntity>> GetAllGastosAguaGrafico();




    }
}
