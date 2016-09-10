using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ReturnStatementWithCodeAnalysis<TExpression> :
        IReturnStatement<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitReturnStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
