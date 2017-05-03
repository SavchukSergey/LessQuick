using System.Collections.Generic;

namespace LessQuick.Nodes {
    public class RulesetNode : BaseNode {

        public IList<SelectorNode> Selectors { get; } = new List<SelectorNode>();

        public IList<BaseNode> Children { get; } = new List<BaseNode>();

        public override void ToLess(LessWriter writer) {
            for (var i = 0; i < Selectors.Count; i++) {
                if (i != Selectors.Count - 1) {
                    writer.Comma();
                }
                Selectors[i].ToLess(writer);
            }
            writer.StartBlock();
            foreach (var child in Children) {
                child.ToLess(writer);
            }
            writer.EndBlock();
        }
    }
}
