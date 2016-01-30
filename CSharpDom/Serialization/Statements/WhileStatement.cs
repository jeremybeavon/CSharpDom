using System;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class WhileStatement : IWhileStatement<Expression, Statement>
    {
        public Expression Condition { get; set; }

        public Statement Statement { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitWhileStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitWhileStatementChildren(this, visitor);
        }
    }
}
