using System;
using System.Collections.Generic;
using System.IO;

namespace LessQuick.Expressions.Functions {
    public abstract class BaseCallFunctionExpression : BaseExpression {

        public abstract string Name { get; }

        public IList<BaseExpression> Arguments { get; } = new List<BaseExpression>();

        public override void ToLess(TextWriter writer) {
            writer.Write(Name);
            writer.Write('(');
            var cnt = Arguments.Count;
            for (var i = 0; i < cnt; i++) {
                var arg = Arguments[i];
                arg.ToLess(writer);
                if (i < cnt - 1) {
                    writer.Write(',');
                    writer.Write(' ');
                }
            }
            writer.Write(')');
        }
    }
}
