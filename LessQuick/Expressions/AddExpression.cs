namespace LessQuick.Expressions {
    public class AddExpression : BaseBinaryExpression {

        public AddExpression() {
        }

        public AddExpression(BaseExpression left, BaseExpression right) : base(left, right) {
        }

        protected override string Operator => "+";

    }
}
