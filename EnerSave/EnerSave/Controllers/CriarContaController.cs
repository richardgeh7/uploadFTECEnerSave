using ConsultasMVC;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EnerSave.Controllers
{
    public class CriarContaController : Controller
    {
        private readonly IUsuarioStore _model;

        public CriarContaController(IUsuarioStore model)
        {
            _model = model;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _model.Post(model);
                
                return Redirect("/Login");
                
            }
            return View();
        }
    }
}
