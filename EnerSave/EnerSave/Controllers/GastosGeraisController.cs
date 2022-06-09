using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnerSave.Controllers
{
    //[Authorize]
    public class GastosGeraisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
