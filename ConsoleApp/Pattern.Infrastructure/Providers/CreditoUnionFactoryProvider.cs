using Pattern.Infrastructure.Factories;
using Pattern.Interfaces.Bases;

namespace Pattern.Infrastructure.Providers
{
    public class CreditoUnionFactoryProvider 
    {
        public static CreditoUnionBase GetCreditoUnionFactory(string numeroConta)
        {
            if (numeroConta.Contains("CITY")) return new ContaCreditoCityUnionFactory();
            if (numeroConta.Contains("NACIONAL")) return new ContaCreditoNacionalUnionFactory();

            return null;
        }
    }
}
