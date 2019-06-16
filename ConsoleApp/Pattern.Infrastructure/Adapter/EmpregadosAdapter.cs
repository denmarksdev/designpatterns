using System.Collections.Generic;
using Pattern.Domain.Domains.EmpregadosDomain;
using Pattern.Domain.Interfaces;

namespace Pattern.Infrastructure.Adapter
{
    public class EmpregadosAdapter : EmpregadosTercerizados, IAlvo
    {
        public List<string> GetEmpregados()
        {
            return base.GetLista();
        }
    }
}

