using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentDB.Models;

namespace StudentDB.DAL
{
    public class EstudanteRepository : IEstudanteRepository, IDisposable
    {
        private EstudanteContext _context;

        public EstudanteRepository(EstudanteContext context)
        {
            _context = context;
        }

        public void Atualiza(Estudante estudante)
        {
            _context.Estudante.Update(estudante);
        }


        public Task Inclui(Estudante estudante)
        {
           return _context.Estudante.AddAsync(estudante);
        }

        public async Task Exclui(int id)
        {
            var estudante = await _context.Estudante.FindAsync(id);
            _context.Remove(estudante);
        }

        public Task<Estudante> GetEstudantePorId(int? id)
        {
            return _context.Estudante.FindAsync(id);
        }

        public Task<List<Estudante>> GetEstudantes()
        {
            return _context.Estudante.ToListAsync();
        }


        public Task<int> Salvar()
        {
            return _context.SaveChangesAsync();
        }


        private bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public bool JaExiste(int id)
        {
           return _context.Estudante.Any( e=> e.Id == id);
        }
    }
}
