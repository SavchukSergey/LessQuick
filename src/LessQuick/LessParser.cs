using LessQuick.Nodes;
using LessQuick.Nodes.Selectors;
using System;
using System.Collections.Generic;

namespace LessQuick {
    public class LessParser {

        public StylesheetNode Parse(string content) {
            var res = new StylesheetNode();
            int index = 0;
            while (index < content.Length) {
                if (SkipWhite(content, ref index)) continue;
                var ch = content[index];
                if (char.IsLetter(ch) || ch == ':') {
                    res.Children.Add(ParseRuleset(content, ref index));
                } else {
                    throw new SyntaxException();
                }
            }
            return res;
        }

        private static RulesetNode ParseRuleset(string content, ref int index) {
            SkipWhite(content, ref index);
            var res = new RulesetNode();
            do {
                var selector = ParseSelector(content, ref index);
            } while (index < content.Length);
            return res;
        }

        private static BaseSelectorNode ParseSelector(string content, ref int index) {
            var selector = ParseSimpleSelector();
        }

        private static SimpleSelectorNode ParseSimpleSelector(string content, ref int index) {
            SkipWhite(content, ref index);
            if (index < content.Length) {
                var res = new SimpleSelectorNode();

                var ch = content[index];
                if (ch == '*') {
                    res.ElementName = "*";
                } else if (char.IsLetter(ch)) {
                    res.ElementName = ParseElementName(content, ref index);
                }
                
                if (ch == ':' || ch == '#' || ch == '[' || ch == '.') {
                    res.Components.Add(ParseSimpleSelectorComponent(content, ref index));
                } else {
                    throw new SyntaxException("selector expected");
                }

                return res;
            } else {
                throw new SyntaxException("selector expected");
            }
        }

        private static BaseSelectorComponentNode ParseSimpleSelectorComponent(string content, ref int index) {
            SkipWhite(content, ref index);
            if (index < content.Length) {
                var ch = content[index];
                if (ch == ':') {
                    return ParsePseudoSelector(content, ref index);
                } else if (ch == '#') {
                    return ParseIdSelector(content, ref index);
                } else if (ch == '[') {
                    return ParseAttributeSelector(content, ref index);
                } else if (ch == '.') {
                    return ParseClassNameSelector(content, ref index);
                } else {
                    throw new SyntaxException("selector expected");
                }
            } else {
                throw new SyntaxException("selector expected");
            }
        }

        private static AttributeSelectorNode ParseAttributeSelector(string content, ref int index) {
            //todo: implement
            throw new NotImplementedException();
        }

        private static ClassNameSelectorNode ParseClassNameSelector(string content, ref int index) {
            //todo: implement
            throw new NotImplementedException();
        }

        private static IdSelectorNode ParseIdSelector(string content, ref int index) {
            //todo: implement
            throw new NotImplementedException();
        }


        private static PseudoSelectorNode ParsePseudoSelector(string content, ref int index) {
            //todo: implement
            throw new NotImplementedException();
        }

        private static string ParseElementName(string content, ref int index) {
            var startIndex = index;
            while (index < content.Length) {
                var ch = content[index];
                if (!char.IsLetter(ch)) break;
                index++;
            }
            if (startIndex == index) {
                throw new SyntaxException("element name expected");
            }
            return content.Substring(startIndex, index - startIndex);
        }

        private static bool SkipWhite(string str, ref int startIndex) {
            var copy = startIndex;
            while (startIndex < str.Length) {
                var ch = str[startIndex];
                if (!char.IsWhiteSpace(ch)) break;
                startIndex++;
            }
            return copy != startIndex;
        }

    }
}
