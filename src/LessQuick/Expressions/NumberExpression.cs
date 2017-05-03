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
                case NumberUnit.Cm:
                    writer.Write("cm");
                    break;
                case NumberUnit.Mm:
                    writer.Write("mm");
                    break;
                case NumberUnit.Inch:
                    writer.Write("in");
                    break;
                case NumberUnit.Px:
                    writer.Write("px");
                    break;
                case NumberUnit.Pt:
                    writer.Write("pt");
                    break;
                case NumberUnit.Vh:
                    writer.Write("vh");
                    break;
                case NumberUnit.Vw:
                    writer.Write("vw");
                    break;
                case NumberUnit.Vmin:
                    writer.Write("vmin");
                    break;
                case NumberUnit.Vmax:
                    writer.Write("vmax");
                    break;
            }
        }
    }
}
