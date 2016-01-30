using System;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class UsingStatement : IUsingStatement<Expression, Statement>
    {
        public Expression Expression { get; set; }

        public Statement Statement { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitUsingStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitUsingStatementChildren(this, visitor);
        }
    }
}
