namespace Pattern.Infrastructure.InterpreterPattern
{
    // A 'Terminal Expression' class
    public class DezExpression : Expression
    {
        public override string Um() => "X";
        public override string Quatro() => "XL";
        public override string Cinco() => "L";
        public override string Nove() => "XC";
        public override int Multiplicador() => 10;
    }
}
