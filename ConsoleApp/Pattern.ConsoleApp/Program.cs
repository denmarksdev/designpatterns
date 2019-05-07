using Pattern.Domain.Aggregate;
using Pattern.Domain.Domains.CarroDomain;
using Pattern.Domain.Domains.FanDomain;
using Pattern.Domain.Domains.JornalDomain;
using Pattern.Domain.Domains.PoliticaDomain;
using Pattern.Domain.Interfaces;
using Pattern.Infrastructure;
using Pattern.Infrastructure.Component;
using Pattern.Infrastructure.ConcretDecorator;
using Pattern.Infrastructure.Providers;
using Pattern.Interfaces.Bases;
using System;
using System.Collections.Generic;

namespace Pattern.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoryExemplo();
            //AbstractFactoryExemplo();
            //SingletoneExemplo();
            //DecoratorExemplo();
            //IteratorExemplo();
            ObserverExemplo();

            Console.ReadKey();
        }

        private static void ObserverExemplo()
        {
            var gClooney = new GClonney("Em amo a minha esposa");
            var tSwift = new TSwift("1981 agora é o meu número favorito");
            var primieroFan = new Fan();
            var segundoFan = new Fan();

            gClooney.AdicionaSeguidor(primieroFan);
            tSwift.AdicionaSeguidor(segundoFan);

            gClooney.Tweet = "Minha esposa não me força a tweetar.";
            tSwift.Tweet = "Eu amo a minha nova musica";
        }

        private static void IteratorExemplo()
        {
            IJornal novaYork = new JornalNovaYork();
            IJornal losAngeles = new JornalLosAngeles();

            IIterator novaYorkIteraror = novaYork.CreateIterator();
            IIterator losAngelesIterator = losAngeles.CreateIterator();

            Console.WriteLine("-------------------  Jonal Nova York");
            ExibirReporters(novaYorkIteraror);

            Console.WriteLine("-------------------  Jonal Los Angeles");
            ExibirReporters(losAngelesIterator);
        }

        private static void ExibirReporters(IIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }

        private static void DecoratorExemplo()
        {
            Carro carro = new CarroCompacto();
            carro = new Navegacao(carro);
            carro = new TetoSolar(carro);
            carro = new AssentosCouro(carro);

            Console.WriteLine(carro.GetDescricao());
            Console.WriteLine($"'{carro.GetPrecoCarro():c2}");
        }

        private static void SingletoneExemplo()
        {
            var nomeSegurado = Politica.Instance.GetNomeSegurado;
            Console.WriteLine(nomeSegurado);
        }

        private static void AbstractFactoryExemplo()
        {
            List<string> numeroContas = new List<string>
            {
                "CITY-456",
                "NACIONAL-987",
                "CHASE-222"
            };

            foreach (var numero in numeroContas)
            {
                CreditoUnionBase creditoUnionBase =
                    CreditoUnionFactoryProvider.GetCreditoUnionFactory(numero);

                if (creditoUnionBase == null)
                    Console.WriteLine($"Desculpe, este numero conta: {numero} é inválido.");
                else
                {
                    var contaEmprestitmo = creditoUnionBase.CriarContaEmprestimo();
                    var contaPoupanca = creditoUnionBase.CriarContaPoupanca();
                }

            }
        }

        private static void FactoryExemplo()
        {
            var fabrica = new ContaFactory() as IUniaoCreditoFactory;
            var contaCity = fabrica.GetContaPoupanca("CITY-321");
            var contaNacional = fabrica.GetContaPoupanca("NACIONAL-987");

            Console.WriteLine(
                $"O saldo da minha conta city é {contaCity.Saldo:c2}" +
                $" e da conta nacional é de {contaNacional.Saldo:c2}");
        }
    }
}
