namespace LessQuick.Expressions {
    public class MulExpression : BaseBinaryExpression {

        public MulExpression() {
        }

        public MulExpression(BaseExpression left, BaseExpression right) : base(left, right) {
        }

        protected override string Operator => "*";

    }
}
