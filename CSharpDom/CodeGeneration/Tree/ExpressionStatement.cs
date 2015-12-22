using System;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExpressionStatement : Statement
    {
        public Expression<Func<object>> Expression { get; set; }

        public RawStatement RawExpression { get; set; }

        public AssignStatement AssignExpression { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
