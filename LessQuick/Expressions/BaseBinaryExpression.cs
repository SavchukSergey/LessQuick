using System.IO;

namespace LessQuick.Expressions {
    public abstract class BaseBinaryExpression : BaseExpression {

        protected BaseBinaryExpression() {
        }

        protected BaseBinaryExpression(BaseExpression left, BaseExpression right) {
            Left = left;
            Right = Right;
        }

        public BaseExpression Left { get; set; }

        public BaseExpression Right { get; set; }

        protected abstract string Operator { get; }

        public override void ToLess(TextWriter writer) {
            Left.ToLess(writer);
            writer.Write(' ');
            writer.Write(Operator);
            writer.Write(' ');
        }
    }
}
