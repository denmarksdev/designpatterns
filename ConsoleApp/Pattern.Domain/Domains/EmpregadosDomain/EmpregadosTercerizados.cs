using System.Collections.Generic;

namespace Pattern.Domain.Domains.EmpregadosDomain
{
    public class EmpregadosTercerizados
    {
        public List<string> GetLista()
        {
            return new List<string>
            {
                "Peter",
                "Paul",
                "Puru",
                "Prethi"
            };
        }
    }
}