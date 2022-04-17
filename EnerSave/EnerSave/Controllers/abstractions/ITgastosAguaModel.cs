using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers.abstractions
{
    public interface ITgastosAguaModel
    {
        Task<IEnumerable<TgastosAgua>> getAllGastosAgua();
        Task<TgastosAgua> getGastosAguaById(int? id);
        Task<int> postGastosAgua(GastosAguaViewModel tgastosAgua);
        Task<int> updateGastosAgua(TgastosAgua tgastosAgua);
        Task<int> deleteGastosAgua(int id);
        bool gastosAguaExists(int id);
    }
}
