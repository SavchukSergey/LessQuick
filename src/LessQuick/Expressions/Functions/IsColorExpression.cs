namespace LessQuick.Expressions.Functions {
    public class IsColorExpression : BaseCallFunctionExpression {

        public IsColorExpression() {
        }

        public IsColorExpression(BaseExpression expr) {
            Arguments.Add(expr);
        }

        public override string Name => "iscolor";

    }
}
