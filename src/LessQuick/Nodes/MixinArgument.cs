using System.IO;
using LessQuick.Expressions;

namespace LessQuick.Nodes {
    public class MixinArgument {

        public MixinArgument() {
        }

        public MixinArgument(string name) {
            Name = name;
        }

        public MixinArgument(string name, BaseExpression defaultValue) {
            Name = name;
            Default = defaultValue;
        }

        public string Name { get; set; }

        public BaseExpression Default { get; set; }

        public void ToLess(LessWriter writer) {
            writer.WriteMixinName(Name);
            if (Default != null) {
                writer.Write(':');
                writer.Write(' ');
                Default.ToLess(writer);
            }
        }

        public override string ToString() {
            using (var writer = new StringWriter()) {
                ToLess(new LessWriter(writer));
                return writer.GetStringBuilder().ToString();
            }
        }

    }
}
