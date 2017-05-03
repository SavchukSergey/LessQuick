using LessQuick.Expressions;
using LessQuick.Expressions.Functions;
using LessQuick.Nodes;
using System;

namespace LessQuick {
    public static class Program {

        public static void Main2() {
            var ruleset = new StylesheetNode {
                Children = {
                    new AssignmentNode("base", new ColorExpression("#f938ab")),
                    new MixinDeclarationNode("box-shadow")
                        .AddArgument("style")
                        .AddArgument("c", new NumberExpression(50, NumberUnit.Percentage))
                        .SetCondition(new IsColorExpression(new VariableExpression("c")))
                }
            };
            Console.Write(ruleset);
            Console.ReadKey();
        }

        public static void Main() {
            var stylesheet = new LessParser().Parse(@"
html {
    font-size: 16px;
}
");
            Console.Write(stylesheet);
            Console.ReadKey();
        }
    }
}
