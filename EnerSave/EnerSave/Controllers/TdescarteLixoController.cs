using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers
{
    public class TDescarteLixoController : Controller
    {
        private readonly ITdescarteLixoModel _model;

        public TDescarteLixoController(ITdescarteLixoModel model)
        {
            _model = model;
        }

        // GET: TDescarteLixo
        public async Task<IActionResult> Index()
        {
            return View(await _model.getAllDescarteLixo());
        }

        // GET: TDescarteLixo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tDescarteLixo = await _model.getDescarteLixoById(id);
            if (tDescarteLixo == null)
            {
                return NotFound();
            }

            return View(tDescarteLixo);
        }

        // GET: TDescarteLixo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TDescarteLixo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Peso,Reciclavel,Organico,Eletronico,DescricaoLixo,Periodo,UsuarioId")] DescarteLixoViewModel tDescarteLixo)
        {
            if (ModelState.IsValid)
            {
                await _model.postDescarteLixo(tDescarteLixo);
                return RedirectToAction(nameof(Index));
            }
            return View(tDescarteLixo);
        }

        // GET: TDescarteLixo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tDescarteLixo = await _model.getDescarteLixoById(id);
            if (tDescarteLixo == null)
            {
                return NotFound();
            }
            return View(tDescarteLixo);
        }

        // POST: TDescarteLixo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Peso,Reciclavel,Organico,Eletronico,DescricaoLixo,Periodo,UsuarioId")] TdescarteLixo tDescarteLixo)
        {
            if (id != tDescarteLixo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _model.updateDescarteLixo(tDescarteLixo);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TDescarteLixoExists(tDescarteLixo.Id))
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
            return View(tDescarteLixo);
        }

        // GET: TDescarteLixo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tDescarteLixo = await _model.getDescarteLixoById(id);
            if (tDescarteLixo == null)
            {
                return NotFound();
            }

            return View(tDescarteLixo);
        }

        // POST: TDescarteLixo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _model.deleteDescarteLixo(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TDescarteLixoExists(int id)
        {
            return _model.descarteLixoExists(id);
        }
    }
}
