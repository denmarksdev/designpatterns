using StudentDB.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentDB.DAL
{
    public interface IEstudanteRepository : IDisposable
    {
        Task<List<Estudante>> GetEstudantes();
        Task<Estudante> GetEstudantePorId(int? id);
        Task Inclui(Estudante estudante);
        Task Exclui(int id);
        void Atualiza(Estudante estudante);
        Task<int> Salvar();
        bool JaExiste(int id);
    }
}
