namespace Pattern.Infrastructure.InterpreterPattern
{
    public abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0) return;

            if (context.Input.StartsWith(Nove()))
            {
                context.Output += (9 * Multiplicador());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Quatro()))
            {
                context.Output += (4 * Multiplicador());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Cinco()))
            {
                context.Output += (5 * Multiplicador());
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(Um()))
            {
                context.Output += (1 * Multiplicador());
                context.Input = context.Input.Substring(1);
            }
        }

        public abstract string Um();
        public abstract string Quatro();
        public abstract string Cinco();
        public abstract string Nove();
        public abstract int Multiplicador();
    }
}
