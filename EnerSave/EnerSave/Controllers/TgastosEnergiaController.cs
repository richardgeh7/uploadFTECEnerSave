using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers
{
    public class TgastosEnergiaController : Controller
    {
        private readonly ITgastosEnergiaModel _model;

        public TgastosEnergiaController(ITgastosEnergiaModel model)
        {
            _model = model;
        }

        // GET: TgastosEnergia
        public async Task<IActionResult> Index()
        {
            return View(await _model.getAllGastosEnergia());
        }

        // GET: TgastosEnergia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosEnergia = await _model.getGastosEnergiaById(id);
            if (tgastosEnergia == null)
            {
                return NotFound();
            }

            return View(tgastosEnergia);
        }

        // GET: TgastosEnergia/Create
        public async Task<IActionResult> Create()
        {
            ViewData["UsuarioId"] = new SelectList(await _model.getUsuarios(), "Id", "Nome");
            return View();
        }

        // POST: TgastosEnergia/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Kilowatts,Valor,Periodo,UsuarioId")] GastosEnergiaViewModel tgastosEnergia)
        {
            if (ModelState.IsValid)
            {
                await _model.postGastosEnergia(tgastosEnergia);
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(await _model.getUsuarios(), "Id", "Nome");
            return View(tgastosEnergia);
        }

        // GET: TgastosEnergia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosEnergia = await _model.getGastosEnergiaById(id);
            if (tgastosEnergia == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(await _model.getUsuarios(), "Id", "Nome");
            return View(tgastosEnergia);
        }

        // POST: TgastosEnergia/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Kilowatts,Valor,Periodo,UsuarioId")] TgastosEnergia tgastosEnergia)
        {
            if (id != tgastosEnergia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _model.updateGastosEnergia(tgastosEnergia);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TgastosEnergiaExists(tgastosEnergia.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(await _model.getUsuarios(), "Id", "Nome");
            return View(tgastosEnergia);
        }

        // GET: TgastosEnergia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosEnergia = await _model.getGastosEnergiaById(id);
            if (tgastosEnergia == null)
            {
                return NotFound();
            }

            return View(tgastosEnergia);
        }

        // POST: TgastosEnergia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _model.deleteGastosEnergia(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Grafico()
        {
            return View();
        }
        
        public IActionResult Real()
        {
            return View();
        }

        private bool TgastosEnergiaExists(int id)
        {
            return _model.gastosEnergiaExists(id);
        }

        // Função para gerar lista Json
        public async Task<JsonResult> DadosGrafico() 
        {  
           var lista = await _model.getAllGastosEnergia();  
           return Json(lista);  
        }  
    }
}
