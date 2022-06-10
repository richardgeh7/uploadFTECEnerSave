using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers
{
    public class TusuariosController : Controller
    {
        private readonly IUsuarioStore _usuarioStore;

        public TusuariosController(IUsuarioStore usuarioStore)
        {
            _usuarioStore = usuarioStore;
        }

        // GET: Tusuarios
        public async Task<IActionResult> Index()
        {
            return View(await _usuarioStore.GetAll());
        }

        // GET: Tusuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tusuarios = await _usuarioStore.GetById(id);
            if (tusuarios == null)
            {
                return NotFound();
            }

            return View(tusuarios);
        }

        // GET: Tusuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tusuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Login,Senha,Administrador")] UsuarioViewModel tusuarios)
        {
            if (ModelState.IsValid)
            {
                await _usuarioStore.Post(tusuarios);
                return RedirectToAction(nameof(Index));
            }
            return View(tusuarios);
        }

        // GET: Tusuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tusuarios = await _usuarioStore.GetById(id);
            if (tusuarios == null)
            {
                return NotFound();
            }
            return View(tusuarios);
        }

        // POST: Tusuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Login,Senha,Administrador")] UsuarioViewModel tusuarios)
        {
            if (id != tusuarios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _usuarioStore.Update(tusuarios);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TusuariosExists(tusuarios.Id))
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
            return View(tusuarios);
        }

        // GET: Tusuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tusuarios = await _usuarioStore.GetById(id);
            if (tusuarios == null)
            {
                return NotFound();
            }

            return View(tusuarios);
        }

        // POST: Tusuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _usuarioStore.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TusuariosExists(int id)
        {
            return _usuarioStore.Exists(id);
        }
    }
}
