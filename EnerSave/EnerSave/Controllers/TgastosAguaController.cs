using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers
{
    public class TgastosAguaController : Controller
    {
        private readonly ITgastosAguaModel _model;

        public TgastosAguaController(ITgastosAguaModel model)
        {
            _model = model;
        }

        // GET: TgastosAgua
        public async Task<IActionResult> Index()
        {
            return View(await _model.getAllGastosAgua());
        }

        // GET: TgastosAgua/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _model.getGastosAguaById(id);
            if (tgastosAgua == null)
            {
                return NotFound();
            }

            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Create
        public async Task<IActionResult> Create()
        {
            ViewData["UsuarioId"] = new SelectList(await _model.getUsuarios(), "Id", "Nome");
            return View();
        }

        // POST: TgastosAgua/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MetrosCubicos,Periodo,UsuarioId")] GastosAguaViewModel tgastosAgua)
        {
            if (ModelState.IsValid)
            {
                await _model.postGastosAgua(tgastosAgua);
                return RedirectToAction(nameof(Index));
            }

            ViewData["UsuarioId"] = new SelectList(await _model.getUsuarios(), "Id", "Nome");
            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _model.getGastosAguaById(id);
            if (tgastosAgua == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(await _model.getUsuarios(), "Id", "Nome");
            return View(tgastosAgua);
        }

        // POST: TgastosAgua/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MetrosCubicos,Periodo,UsuarioId")] TgastosAgua tgastosAgua)
        {
            if (id != tgastosAgua.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _model.updateGastosAgua(tgastosAgua);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TgastosAguaExists(tgastosAgua.Id))
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
            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _model.getGastosAguaById(id);
            if (tgastosAgua == null)
            {
                return NotFound();
            }

            return View(tgastosAgua);
        }

        // POST: TgastosAgua/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _model.deleteGastosAgua(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: TgastosAgua/Grafico
        public async Task<IActionResult> Grafico()
        {
            ViewData["UsuarioId"] = new SelectList(await _model.getUsuarios(), "Id", "Nome");
            return View();
        }

        private bool TgastosAguaExists(int id)
        {
            return _model.gastosAguaExists(id);
        }

        // Função para gerar lista Json
        public async Task<JsonResult> DadosGrafico() 
        {  
           var lista = await _model.getAllGastosAguaGrafico();  
           return Json(lista);  
        }  
    }
}
