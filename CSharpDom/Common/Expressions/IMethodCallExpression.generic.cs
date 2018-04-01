using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IMethodCallExpression<TExpression, TTypeReference, TArgument> : IMethodCallExpression
        where TExpression : IExpression
        where TTypeReference : ITypeReference
        where TArgument : IArgument
    {
        TExpression Expression { get; }

        IReadOnlyList<TTypeReference> GenericParameters { get; }

        IReadOnlyList<TArgument> Parameters { get; }
    }
}
