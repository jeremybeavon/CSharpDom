using System;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class LockStatement : ILockStatement<Expression, Statement>
    {
        public Expression Expression { get; set; }

        public Statement Statement { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitLockStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitLockStatementChildren(this, visitor);
        }
    }
}
