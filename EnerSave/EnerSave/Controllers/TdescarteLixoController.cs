using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers
{
    //[Authorize]
    public class TdescarteLixoController : Controller
    {
        private readonly IDescarteLixoStore _descarteStore;
        private readonly IUsuarioStore _usuarioStore;

        public TdescarteLixoController(IDescarteLixoStore descateStore, IUsuarioStore usuarioStore)
        {
            _descarteStore = descateStore;
            _usuarioStore = usuarioStore;
        }

        // GET: TgastosAgua
        public async Task<IActionResult> Index()
        {
            return View(await _descarteStore.GetAll());
        }

        // GET: TgastosAgua/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _descarteStore.GetById(id);
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
        public async Task<IActionResult> Create([Bind("Id,Peso,Organico,Reciclavel,Eletronico,Observacao,Periodo,UsuarioId")] DescarteLixoViewModel tgastos)
        {
            if (ModelState.IsValid)
            {
                await _descarteStore.Post(tgastos);
                return RedirectToAction(nameof(Index));
            }
            return View(tgastos);
        }

        // GET: TgastosAgua/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastos = await _descarteStore.GetById(id);
            if (tgastos == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_usuarioStore.GetUsuarios(), "Id", "Nome");
            return View(tgastos);
        }

        // POST: TgastosAgua/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Peso,Organico,Reciclavel,Eletronico,Observacao,Periodo,UsuarioId")] DescarteLixoViewModel tgastos)
        {
            if (id != tgastos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _descarteStore.Update(tgastos);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TgastosExists(tgastos.Id))
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
            return View(tgastos);
        }

        // GET: TgastosAgua/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _descarteStore.GetById(id);
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
            await _descarteStore.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TgastosExists(int id)
        {
            return _descarteStore.Exists(id);
        }


    }
}