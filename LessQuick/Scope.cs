namespace LessQuick {
    public class Scope {

        private Scope _parent;

        public Scope() {
        }

        public Scope(Scope parent) {
            _parent = parent;
        }

    }
}
