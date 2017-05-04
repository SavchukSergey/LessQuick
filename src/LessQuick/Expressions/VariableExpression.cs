namespace LessQuick.Expressions {
    public class VariableExpression : BaseExpression {

        public string Name { get; set; }

        public VariableExpression() {
        }

        public VariableExpression(string name) {
            Name = name;
        }

        public override void ToLess(LessWriter writer) {
            writer.WriteVariableName(Name);
        }
    }
}
