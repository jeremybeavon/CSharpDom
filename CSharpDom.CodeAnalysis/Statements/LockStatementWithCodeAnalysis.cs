using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class LockStatementWithCodeAnalysis<TExpression, TStatement> :
        ILockStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Expression { get; set; }

        public abstract TStatement Statement { get; set; }

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
