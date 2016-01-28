using System;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ReturnStatement : Statement
    {
        public Expression<Func<object>> Expression { get; set; }

        public string RawExpression { get; set; }
    }
}
