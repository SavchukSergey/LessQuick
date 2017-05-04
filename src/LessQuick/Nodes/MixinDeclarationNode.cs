using LessQuick.Expressions;
using System.Collections.Generic;

namespace LessQuick.Nodes {
    public class MixinDeclarationNode : RulesetNode {

        public string Name { get; set; }

        public BaseExpression When { get; set; }

        public IList<MixinArgument> Arguments { get; } = new List<MixinArgument>();

        public MixinDeclarationNode() {
        }

        public MixinDeclarationNode(string name) {
            Name = name;
        }

        public MixinDeclarationNode AddArgument(string name) {
            Arguments.Add(new MixinArgument(name));
            return this;
        }

        public MixinDeclarationNode AddArgument(string name, BaseExpression defaultValue) {
            Arguments.Add(new MixinArgument(name, defaultValue));
            return this;
        }

        public MixinDeclarationNode SetCondition(BaseExpression expression) {
            When = expression;
            return this;
        }

        public override void ToLess(LessWriter writer) {
            writer.Write('.');
            writer.Write(Name);

            writer.Write('(');
            var cnt = Arguments.Count;
            for (var i = 0; i < cnt; i++) {
                var arg = Arguments[i];
                arg.ToLess(writer);
                if (i < cnt - 1) {
                    writer.Write(',');
                    writer.Write(' ');
                }
            }
            writer.Write(')');
            writer.Write(' ');
            if (When != null) {
                writer.Write("when (");
                When.ToLess(writer);
                writer.Write(')');
                writer.Write(' ');
            }

            writer.WriteStartBlock();
            base.ToLess(writer);
            writer.WriteEndBlock();
        }

    }
}
