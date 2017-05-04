using System.Collections.Generic;

namespace LessQuick.Nodes.Selectors {
    public class SelectorNode : BaseNode {

        public IList<SimpleSelectorNode> Selectors { get; } = new List<SimpleSelectorNode>();

        public override void ToLess(LessWriter writer) {
            for (var i = 0; i < Selectors.Count; i++) {
                if (i != 0) writer.WriteComma();
                Selectors[i].ToLess(writer);
            }
        }
    }
}
