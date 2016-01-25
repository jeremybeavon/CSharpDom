using System;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ReturnStatement : Statement
    {
        public Expression<Func<object>> Expression { get; set; }

        public string RawExpression { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
        }
    }
}
