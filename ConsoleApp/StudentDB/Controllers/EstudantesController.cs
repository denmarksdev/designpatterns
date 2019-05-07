using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDB.DAL;
using StudentDB.Models;

namespace StudentDB.Controllers
{
    public class EstudantesController : Controller
    {
        private readonly IEstudanteRepository _repository;

        public EstudantesController(IEstudanteRepository repository)
        {
            _repository = repository;
        }

        // GET: Estudantes
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetEstudantes());
        }

        // GET: Estudantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _repository.GetEstudantePorId(id);
            if (estudante == null)
            {
                return NotFound();
            }

            return View(estudante);
        }

        // GET: Estudantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estudantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Ano")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                await _repository.Inclui(estudante);
                await _repository.Salvar();
                return RedirectToAction(nameof(Index));
            }
            return View(estudante);
        }

        // GET: Estudantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _repository.GetEstudantePorId(id);
            if (estudante == null)
            {
                return NotFound();
            }
            return View(estudante);
        }

        // POST: Estudantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Ano")] Estudante estudante)
        {
            if (id != estudante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Atualiza(estudante);
                    await _repository.Salvar();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudanteExists(estudante.Id))
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
            return View(estudante);
        }

        // GET: Estudantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _repository.GetEstudantePorId(id);
            if (estudante == null)
            {
                return NotFound();
            }

            return View(estudante);
        }

        // POST: Estudantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.Exclui(id);
            await _repository.Salvar();
            return RedirectToAction(nameof(Index));
        }

        private  bool EstudanteExists(int id)
        {
            return  _repository.JaExiste(id);
        }
    }
}
