using System;
using Pattern.Domain.Domains.BancoDomain;

namespace Pattern.Infrastructure.CommandPattern
{
    public class CalculadoraCommand : Command
    {
        private char _operador;
        private int _operando;
        private Calculadora _calculadora;

        public CalculadoraCommand(Calculadora calculadora, char operador, int operando)
        {
            _calculadora = calculadora;
            _operador = operador;
            _operando = operando;
        }

        public char Operador
        {
            set { _operador = value ;}
        }

        public int Operando => _operando;

        public override void Execute()
        {
            _calculadora.Operacao(_operador, _operando);
        }

        public override void UnExecute()
        {
            _calculadora.Operacao(Undo(_operador), _operando);
        }

        private char Undo(char operador)
        {
            switch (operador)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default :
                    throw new ArgumentException($"Operador {operador} não existe!"); 
            }
        }

    }
}
