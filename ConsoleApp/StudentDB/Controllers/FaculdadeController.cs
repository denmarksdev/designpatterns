using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentDB.DAL;
using StudentDB.Models;

namespace StudentDB.Controllers
{
    public class FaculdadeController : Controller
    {
        private readonly IGenericRepository<Faculdade> _repository;

        public FaculdadeController(IGenericRepository<Faculdade> repository)
        {
            _repository = repository;
        }

        // GET: Faculdade
        public async Task<IActionResult> Index()
        {
            return View(await _repository.Get());
        }

        // GET: Faculdade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faculdade = (await _repository.Get(f => f.Id == id)).FirstOrDefault();
            if (faculdade == null)
            {
                return NotFound();
            }

            return View(faculdade);
        }

        // GET: Faculdade/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Faculdade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Faculdade faculdade)
        {
            if (ModelState.IsValid)
            {
                await _repository.Inclui(faculdade);
                await _repository.Salvar();
                return RedirectToAction(nameof(Index));
            }
            return View(faculdade);
        }

        // GET: Faculdade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faculdade = (await _repository.Get( f=> f.Id == id)).FirstOrDefault();
            if (faculdade == null)
            {
                return NotFound();
            }
            return View(faculdade);
        }

        // POST: Faculdade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Faculdade faculdade)
        {
            if (id != faculdade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Atualiza(faculdade);
                    await _repository.Salvar();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await FaculdadeExists(faculdade.Id))
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
            return View(faculdade);
        }

        // GET: Faculdade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faculdade = await _repository.Get(f => f.Id == id);
            if (faculdade == null)
            {
                return NotFound();
            }

            return View(faculdade);
        }

        // POST: Faculdade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faculdade = await _repository.Get(f => f.Id == id);
            await _repository.Salvar();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> FaculdadeExists(int id)
        {
            return (await _repository.Get(f => f.Id == id)).Any();
        }
    }
}
