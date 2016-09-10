using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class WhileStatementWithCodeAnalysis<TExpression, TStatement> :
        IWhileStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Condition { get; set; }

        public abstract TStatement Statement { get; set; }

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
