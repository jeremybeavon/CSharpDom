using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface INewExpression<TTypeReference, TArgument> : INewExpression
        where TTypeReference : ITypeReference
        where TArgument : IArgument
    {
        TTypeReference Type { get; }

        IReadOnlyList<TArgument> Parameters { get; }
    }
}
