using System.IO;

namespace LessQuick.Nodes {
    public abstract class BaseNode {

        public abstract void ToLess(TextWriter writer);

        public override string ToString() {
            using (var writer = new StringWriter()) {
                ToLess(writer);
                return writer.GetStringBuilder().ToString();
            }
        }
    }
}
