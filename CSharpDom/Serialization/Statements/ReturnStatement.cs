using System;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class ReturnStatement : IReturnStatement<Expression>
    {
        public Expression Expression { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitReturnStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
