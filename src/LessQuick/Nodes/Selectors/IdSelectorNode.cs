namespace LessQuick.Nodes.Selectors {
    public class IdSelectorNode : BaseSelectorComponentNode {

        public string Id { get; set; }

        public override void ToLess(LessWriter writer) {
            writer.WriteId(Id);
        }
    }
}
