using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractVariableDeclarationStatement<TTypeReference, TExpression> :
        IVariableDeclarationStatement<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract IReadOnlyList<TExpression> Expressions { get; }

        public abstract TTypeReference Type { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitVariableDeclarationStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
