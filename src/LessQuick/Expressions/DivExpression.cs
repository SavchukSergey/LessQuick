namespace LessQuick.Expressions {
    public class DivExpression : BaseBinaryExpression {

        public DivExpression() {
        }

        public DivExpression(BaseExpression left, BaseExpression right) : base(left, right) {
        }

        protected override string Operator => "/";

    }
}
