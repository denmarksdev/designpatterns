using Pattern.Domain.Domains.PoliticaDomain;
using Xunit;

namespace Pattern.Test
{
    public class PoliticaTeste
    {
        [Fact]
        public void PoliticaEhUmSingleton()
        {
            Assert.Same(Politica.Instance, Politica.Instance);
        }
    }
}
