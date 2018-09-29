using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IMethodCallExpression<TExpression, TArgument> : IMethodCallExpression
        where TExpression : IGenericExpression
        where TArgument : IArgument
    {
        TExpression Expression { get; }

        IReadOnlyList<TArgument> Parameters { get; }
    }
}
