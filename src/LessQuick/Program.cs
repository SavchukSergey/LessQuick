using LessQuick.Expressions;
using LessQuick.Expressions.Functions;
using LessQuick.Nodes;
using System;

namespace LessQuick {
    public static class Program {

        public static void Main() {
            var ruleset = new RulesetNode {
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
    }
}
