using System.IO;

namespace LessQuick.Expressions {
    public abstract class BaseExpression {

        public abstract void ToLess(TextWriter writer);

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
