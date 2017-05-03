using System;

namespace LessQuick.Nodes.Selectors {
    public class ClassNameSelectorNode : BaseSelectorComponentNode {

        public string ClassName { get; set; }

        public override void ToLess(LessWriter writer) {
            throw new NotImplementedException();
        }
    }
}
