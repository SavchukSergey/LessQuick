using System.IO;

namespace LessQuick.Nodes {
    public abstract class BaseNode {

        public abstract void ToLess(LessWriter writer);

        public override string ToString() {
            var inner = new StringWriter();
            using (var writer = new LessWriter(new StringWriter())) {
                ToLess(writer);
                return inner.GetStringBuilder().ToString();
            }
        }
    }
}
