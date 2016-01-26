using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface IVariableDeclarationStatement<TTypeReference, TExpression> : IVariableDeclarationStatement
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        TTypeReference Type { get; }

        IReadOnlyList<TExpression> Expressions { get; }
    }
}
