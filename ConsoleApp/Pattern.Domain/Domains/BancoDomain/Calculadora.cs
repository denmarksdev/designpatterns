namespace Pattern.Domain.Domains.BancoDomain
{
    // The 'Receiver' class
    public class Calculadora
    {
        private int _curr = 0;
        public void Operacao(char operador, int operando)
        {
            switch (operador)
            {
                case '+': _curr += operando;break;
                case '-': _curr -= operando; break;
                case '*': _curr *= operando; break;
                case '/': _curr /= operando; break;
            }

            System.Console.WriteLine(
                "Valor atual = {0,3} (Segue {1} {2})",
                    _curr, operador, operando);
        }
    }
}
