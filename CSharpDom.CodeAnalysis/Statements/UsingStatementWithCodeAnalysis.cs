using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class UsingStatementWithCodeAnalysis<TExpression, TStatement> :
        IUsingStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Expression { get; set; }

        public abstract TStatement Statement { get; set; }

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
