using System.Collections.Generic;

namespace LessQuick.Nodes {
    public class StylesheetNode : BaseNode {

        public IList<BaseNode> Children { get; } = new List<BaseNode>();

        public override void ToLess(LessWriter writer) {
            foreach (var child in Children) {
                writer.WriteLine(child.ToString());
            }
        }
    }
}
