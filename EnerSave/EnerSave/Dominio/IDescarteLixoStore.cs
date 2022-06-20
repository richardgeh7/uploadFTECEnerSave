using ConsultasMVC.dbenersave;
using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC
{
    public interface IDescarteLixoStore
    {
        Task<IEnumerable<DescarteLixoEntity>> GetAll();
        Task<DescarteLixoEntity> GetById(int? id);
        Task<int> Post(DescarteLixoViewModel model);
        Task<int> Update(DescarteLixoViewModel model);
        Task<int> Delete(int id);
        bool Exists(int id);
        Task<IEnumerable<DescarteLixoEntity>> GetAllDescarteLixoGrafico();
    }
}
