namespace Pattern.Infrastructure.InterpreterPattern
{
    // A 'Terminal Expression' class
    public class UmExpression : Expression
    {
        public override string Um() => "I";
        public override string Quatro() => "IV";
        public override string Cinco() => "V";
        public override string Nove() => "IX";
        public override int Multiplicador() => 1;
    }
}