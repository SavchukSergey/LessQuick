using System.IO;
using LessQuick.Expressions;

namespace LessQuick.Nodes {
    public class VariableDeclarationNode : BaseNode {

        public VariableDeclarationNode() {
        }

        public VariableDeclarationNode(string name, BaseExpression value) {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }

        public BaseExpression Value { get; set; }

        public override void ToLess(TextWriter writer) {
            writer.Write('@');
            writer.Write(Name);
            writer.Write(':');
            writer.Write(' ');
            Value.ToLess(writer);
            writer.Write(';');
        }

    }
}
