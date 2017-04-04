using System.Globalization;
using System.IO;

namespace LessQuick.Expressions {
    public class NumberExpression : BaseExpression {

        public NumberExpression() {
        }

        public NumberExpression(double value, NumberUnit unit) {
            Value = value;
            Unit = unit;
        }

        public double Value { get; set; }

        public NumberUnit Unit { get; set; }

        public override void ToLess(TextWriter writer) {
            writer.Write(Value.ToString(CultureInfo.InvariantCulture));
            switch(Unit) {
                case NumberUnit.Percentage:
                    writer.Write('%');
                    break;
            }
        }
    }
}
