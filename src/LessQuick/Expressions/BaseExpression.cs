using LessQuick.Nodes;

namespace LessQuick.Expressions {
    public abstract class BaseExpression : BaseNode {

        public static BaseExpression Parse(string str, ref int startIndex) {
            SkipWhite(str, ref startIndex);
            return null;
        }

        private static void SkipWhite(string str, ref int startIndex) {
            while (startIndex < str.Length) {
                var ch = str[startIndex];
                if (!char.IsWhiteSpace(ch)) break;
                startIndex++;
            }
        }
    }
}
