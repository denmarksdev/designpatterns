using Pattern.Domain.Domains.BancoDomain;
using System;
using System.Collections.Generic;

namespace Pattern.Infrastructure.CommandPattern
{
    // The 'Invoker' Class
    public class User
    {
        private Calculadora _calculadora = new Calculadora();
        private List<Command> _comandos = new List<Command>();
        private int _atual = 0;

        public void Redo(int niveis)
        {
            Console.WriteLine("\n---- Redo {0} níveis ", niveis);
            for (int i = 0; i < niveis; i++)
            {
                if (_atual < _comandos.Count - 1)
                {
                    Command command = _comandos[_atual++];
                    command.Execute();
                }
            }
        }

        public void Undo(int niveis)
        {
            Console.WriteLine("\n---- Undo {0} níveis ", niveis);
            for (int i = 0; i < niveis; i++)
            {
                if (_atual > 0)
                {
                    Command command = _comandos[--_atual];
                    command.UnExecute();
                }
            }
        }

        public void Compute(char operador, int operando)
        {
            Command command = new CalculadoraCommand(
                _calculadora, operador, operando );

            command.Execute();

            _comandos.Add(command);
            _atual++;
        }
    }
}
