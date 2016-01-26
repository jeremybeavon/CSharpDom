using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface INewArrayExpression<TTypeReference, TExpression> : INewArrayExpression
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        TTypeReference ElementType { get; }

        IReadOnlyList<int> Dimensions { get; }

        IReadOnlyList<TExpression> InitialSizeExpressions { get; }
    }
}
