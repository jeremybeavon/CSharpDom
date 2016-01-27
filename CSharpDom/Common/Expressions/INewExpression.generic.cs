using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface INewExpression<TTypeReference, TExpression> : INewExpression
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        TTypeReference Type { get; }

        IReadOnlyList<TExpression> Parameters { get; }
    }
}
