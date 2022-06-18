using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers
{
    //[Authorize]
    public class TgastosAguaController : Controller
    {
        private readonly ITgastosAguaStore _aguaStore;
        private readonly IUsuarioStore _usuarioStore;

        public TgastosAguaController(ITgastosAguaStore aguaStore, IUsuarioStore usuarioStore)
        {
            _aguaStore = aguaStore;
            _usuarioStore = usuarioStore;
        }

        // GET: TgastosAgua
        public async Task<IActionResult> Index()
        {
            return View(await _aguaStore.GetAll());
        }

        // GET: TgastosAgua/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _aguaStore.GetById(id);
            if (tgastosAgua == null)
            {
                return NotFound();
            }

            ViewData["UsuarioId"] = new SelectList(_usuarioStore.GetUsuarios(), "Id", "Nome");

            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_usuarioStore.GetUsuarios(), "Id", "Nome");

            return View();
        }

        // POST: TgastosAgua/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MetrosCubicos,Periodo,UsuarioId")] GastosAguaViewModel tgastosAgua)
        {
            if (ModelState.IsValid)
            {
                await _aguaStore.Post(tgastosAgua);
                return RedirectToAction(nameof(Index));
            }
            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _aguaStore.GetById(id);
            if (tgastosAgua == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_usuarioStore.GetUsuarios(), "Id", "Nome");

            return View(tgastosAgua);
        }

        // POST: TgastosAgua/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MetrosCubicos,Periodo,UsuarioId")] GastosAguaEntity tgastosAgua)
        {
            if (id != tgastosAgua.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _aguaStore.Update(tgastosAgua);
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
            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _aguaStore.GetById(id);
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
            await _aguaStore.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TgastosAguaExists(int id)
        {
            return _aguaStore.Exists(id);
        }

        // GET: TgastosAgua/Grafico
        public async Task<IActionResult> Grafico()
        {
            ViewData["UsuarioId"] = new SelectList(_usuarioStore.GetUsuarios(), "Id", "Nome");
            return View();
        }

        // Função para gerar lista Json
        public async Task<JsonResult> DadosGrafico()
        {
            var lista = await _aguaStore.GetAllGastosAguaGrafico();
            return Json(lista);
        }

    }
}
