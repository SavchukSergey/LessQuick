namespace LessQuick.Expressions {
    public class SubtractExpression : BaseBinaryExpression {

        public SubtractExpression() {
        }

        public SubtractExpression(BaseExpression left, BaseExpression right) : base(left, right) {
        }

        protected override string Operator => "-";

    }
}
