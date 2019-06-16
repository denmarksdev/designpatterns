namespace Pattern.Infrastructure.InterpreterPattern
{
    // The 'Context' class
    public class Context
    {
        private int _output;

        public Context(string input)
        {
            Input = input;
        }

        public string Input { get; set; }
        public int Output { get; set; }
    }
}
