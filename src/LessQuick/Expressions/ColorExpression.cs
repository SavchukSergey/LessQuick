using System.IO;

namespace LessQuick.Expressions {
    public class ColorExpression : BaseExpression {

        public ColorExpression() {
        }

        public ColorExpression(string value) {
            Value = value;
        }

        public string Value { get; set; }

        public override void ToLess(LessWriter writer) {
            writer.Write(Value);
        }

        public override string ToString() {
            return Value;
        }

    }
}