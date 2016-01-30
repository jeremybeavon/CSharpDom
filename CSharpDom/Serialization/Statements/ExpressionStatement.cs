using System;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class ExpressionStatement : IExpressionStatement<Expression>
    {
        public Expression Expression { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitExpressionStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
