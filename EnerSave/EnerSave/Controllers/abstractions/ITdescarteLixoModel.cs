using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers.abstractions
{
    public interface ITdescarteLixoModel
    {
        Task<IEnumerable<TdescarteLixo>> getAllDescarteLixo();
        Task<TdescarteLixo> getDescarteLixoById(int? id);
        Task<int> postDescarteLixo(DescarteLixoViewModel tDescarteLixo);
        Task<int> updateDescarteLixo(TdescarteLixo tDescarteLixo);
        Task<int> deleteDescarteLixo(int id);
        bool descarteLixoExists(int id);
    }
}
