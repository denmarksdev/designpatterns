using StudentDB.Models;
using System;

namespace StudentDB.DAL
{
    public class UnitOfWork : IDisposable
    {
        private IGenericRepository<Faculdade> _faculdadeRepository;
        private IEstudanteRepository _estudanteRepository;
        private readonly EstudanteContext _estudanteContext;

        public UnitOfWork(EstudanteContext estudanteContext)
        {
            _estudanteContext = estudanteContext;
        }

        public IGenericRepository<Faculdade> FaculdadeRepo
        {
            get
            {
                if (_faculdadeRepository == null)
                    _faculdadeRepository = new GenericRepository<Faculdade>(_estudanteContext);

                return _faculdadeRepository;
            }
        }

        public IEstudanteRepository EstudanteRepo
        {
            get
            {
                if (_estudanteRepository == null)
                    _estudanteRepository = new EstudanteRepository(_estudanteContext);

                return _estudanteRepository;
            }
        }
        
        private bool _disposed;
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
                    _estudanteContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
