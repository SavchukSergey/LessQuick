using System;
using System.Collections.Generic;

namespace LessQuick.Nodes.Selectors {
    public class SimpleSelectorNode : SelectorNode {

        public string ElementName { get; set; }

        public IList<BaseSelectorComponentNode> Components { get; } = new List<BaseSelectorComponentNode>();

        public override void ToLess(LessWriter writer) {
            throw new NotImplementedException();
        }
    }
}
