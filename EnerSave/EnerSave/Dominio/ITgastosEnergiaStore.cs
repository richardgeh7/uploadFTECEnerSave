using ConsultasMVC.dbenersave;
using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC
{
    public interface ITgastosEnergiaStore
    {
        Task<IEnumerable<GastosEnergiaEntity>> GetAll();
        Task<GastosEnergiaEntity> GetById(int? id);
        Task<int> Post(GastosEnergiaViewModel model);
        Task<int> Update(GastosEnergiaEntity model);
        Task<int> Delete(int id);
        bool Exists(int id);
    }
}
