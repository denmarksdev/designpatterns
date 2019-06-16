using Pattern.Infrastructure.Shared;

namespace Pattern.Infrastructure.InterpreterPattern
{

    // A 'Terminal Expression' class
    public class MilExpression : Expression
    {
        public override string Um() => "M";
        public override string Quatro() => Constant.EMPTY_ROMAN;
        public override string Cinco() => Constant.EMPTY_ROMAN;
        public override string Nove() => Constant.EMPTY_ROMAN;
        public override int Multiplicador() => 1000;
    }
}