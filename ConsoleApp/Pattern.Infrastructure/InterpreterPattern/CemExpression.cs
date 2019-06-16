using Pattern.Infrastructure.Shared;

namespace Pattern.Infrastructure.InterpreterPattern
{
    // A 'Terminal Expression' class
    public class CemExpression : Expression
    {
        public override string Um() => "C";
        public override string Quatro() => "CD";
        public override string Cinco() => "D";
        public override string Nove() =>  "CM";
        public override int Multiplicador() => 100; 
    }
}
