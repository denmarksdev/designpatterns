using Pattern.Domain.Aggregate;
using Pattern.Domain.Domains.AprovadorDomain;
using Pattern.Domain.Domains.CarroDomain;
using Pattern.Domain.Domains.EmpregadosDomain;
using Pattern.Domain.Domains.FanDomain;
using Pattern.Domain.Domains.JornalDomain;
using Pattern.Domain.Domains.PoliticaDomain;
using Pattern.Domain.Interfaces;
using Pattern.Infrastructure;
using Pattern.Infrastructure.Adapter;
using Pattern.Infrastructure.Builder;
using Pattern.Infrastructure.CommandPattern;
using Pattern.Infrastructure.Component;
using Pattern.Infrastructure.ConcretDecorator;
using Pattern.Infrastructure.Factories;
using Pattern.Infrastructure.InterpreterPattern;
using Pattern.Infrastructure.MediatorPattern;
using Pattern.Infrastructure.Providers;
using Pattern.Infrastructure.VisitorPattern;
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
            //ObserverExemplo();
            //BuilderExemplo();
            //AdapterExemplo();
            //CompositeExemplo();
            //ChainOfResponsibiltyExemplo();
            //CommandExemplo();
            //InterpreterExemplo();
            //MediatorExemplo();

            VisitorExemplo();

            Console.ReadKey();
        }

        private static void VisitorExemplo()
        {
            Empregados empregados = new Empregados();
            empregados.Anexar(new AmandaEmp());
            empregados.Anexar(new DiretorEmp());
            empregados.Anexar(new PresidenteEmp());

            empregados.Aceitar(new VisitanteEntrada());
            empregados.Aceitar(new VisitanteFerias());
        }

        private static void MediatorExemplo()
        {
            SalaBatePapo salaBatePapo = new SalaBatePapo();

            Participante denis = new Ator("Denis");
            Participante jennifer = new Ator("Jennifer");
            Participante bruce = new Ator("Bruce");
            Participante tom = new Ator("Tom");
            Participante tony = new OutroParticipante("Tony");

            salaBatePapo.Registrar(denis);
            salaBatePapo.Registrar(jennifer);
            salaBatePapo.Registrar(bruce);
            salaBatePapo.Registrar(tom);
            salaBatePapo.Registrar(tony);

            denis.Enviar("Tom", "Ei Tom! E tenho uma missão para voçê.");
            jennifer.Enviar("Bruce", "Me ensine a atuar e te ensinarei a dançar");
            bruce.Enviar("Denis", "Por que você não fez mais nenhum stand-up?");
            jennifer.Enviar("Tom", "Você gosta de matemática?");
            tom.Enviar("Tony", "Ensine-me a cantar");
        }

        private static void InterpreterExemplo()
        {
            string roman = "MMXVIIII";
            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>
            {
                new MilExpression(),
                new CemExpression(),
                new DezExpression(),
                new UmExpression()
            };

            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($" {roman} = {context.Output}");
        }

        private static void CommandExemplo()
        {
            var user = new User();
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);

            user.Redo(3);
        }

        private static void ChainOfResponsibiltyExemplo()
        {
            // Configurar as responsabilidades
            Aprovador ronny = new  Diretor();
            Aprovador bobby = new VicePresidente();
            Aprovador rick = new Presidente();

            ronny.SetSucessor(bobby);
            bobby.SetSucessor(rick);

            // Gerar e processar
            Compra compra = new Compra(8884, 350.00, "Ativos");
            ronny.ProcessarRequisicao(compra);

            compra = new Compra(56775, 33390.10, "Projeto Negro");
            ronny.ProcessarRequisicao(compra);

            compra = new Compra(45205, 1444400.10, "Projeto BBD");
            ronny.ProcessarRequisicao(compra);
        }

        private static void CompositeExemplo()
        {
            Empregado rick = new Empregado
            {
                Id = 1,
                Nome = "Rick",
                Avaliacao = 3,
            };
            Empregado mike = new Empregado
            {
                Id = 2,
                Nome = "Mike",
                Avaliacao = 4,
            };
            Empregado amanda = new Empregado
            {
                Id = 3,
                Nome = "Amanda",
                Avaliacao = 5,
            };
            Empregado olivia = new Empregado
            {
                Id = 4,
                Nome = "Olivia",
                Avaliacao = 2,
            };

            Supervisor ronny = new Supervisor
            {
                Id = 7,
                Nome = "Ronny",
                Avaliacao = 3
            };

            Supervisor bobby = new Supervisor
            {
                Id = 8,
                Nome = "Bobby",
                Avaliacao = 3
            };

            ronny.IncluirSubordinado(rick);
            ronny.IncluirSubordinado(mike);

            bobby.IncluirSubordinado(amanda);
            bobby.IncluirSubordinado(olivia);

            Console.WriteLine("\n-- Podemos ver a performance dos empregados " +
                "Resumo ---------");

            rick.ResumoPerformance();

            Console.WriteLine("\n-- Podemos ver a performance dos supervisores " +
                "Resumo da performabde dos Subordinados ---------");

            ronny.ResumoPerformance();
            foreach (var subordinado in ronny.Subordinados)
            {
                subordinado.ResumoPerformance();
            }


            Console.WriteLine("\n--------------------------");

            bobby.ResumoPerformance();
            foreach (var subordinado in bobby.Subordinados)
            {
                subordinado.ResumoPerformance();
            }
        }

        private static void AdapterExemplo()
        {
            Console.WriteLine("Lista de empregados tercerizados");
            Console.WriteLine("--------------------------------");
            var adapter = new EmpregadosAdapter();
            foreach (var empregado in adapter.GetEmpregados())
            {
                Console.WriteLine(empregado);
            }
        }

        private static void BuilderExemplo()
        {
            var superBuilder = new SuperCarroBuilder(new CarroCompleto());
            var comumBuilder = new CarroComumBuilder(new CarroCompleto());

            var factory = new CarroFactory();
            var builders = new List<CarroBuilder>
            {
                superBuilder, comumBuilder
            };

            builders.ForEach(b =>
            {
                var c = factory.Build(b);
                Console.WriteLine($"O carro requesitado por " +
                    $"{b.GetType().Name}: " +
                    $"\n--------------------------------------------------" +
                    $"\nCavalos: {c.Cavalos}" +
                    $"\nNovo recurso: {c.NovoRecurso} " +
                    $"\nVelecidade máxima: {c.VelocidadeMPH} mph\n");
            });
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
