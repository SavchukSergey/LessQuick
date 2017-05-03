using System.Collections.Generic;
using System.IO;

namespace LessQuick.Nodes {
    public class StylesheetNode : BaseNode {

        public IList<BaseNode> Children { get; } = new List<BaseNode>();

        public override void ToLess(TextWriter writer) {
            foreach (var child in Children) {
                writer.WriteLine(child.ToString());
            }
        }
    }
}
