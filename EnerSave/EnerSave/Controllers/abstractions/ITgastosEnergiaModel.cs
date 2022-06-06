using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers.abstractions
{
    public interface ITgastosEnergiaModel
    {
        Task<IEnumerable<TgastosEnergia>> getAllGastosEnergia();
        Task<TgastosEnergia> getGastosEnergiaById(int? id);
        Task<int> postGastosEnergia(GastosEnergiaViewModel tgastosEnergia);
        Task<int> updateGastosEnergia(TgastosEnergia tgastosEnergia);
        Task<int> deleteGastosEnergia(int id);
        bool gastosEnergiaExists(int id);
        Task<IEnumerable<Tusuarios>> getUsuarios();
    }
}
