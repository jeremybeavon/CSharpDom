using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IArrayIndexExpression<TExpression, TArgument> : IArrayIndexExpression
		where TExpression : IExpression
        where TArgument : IArgument
    {
        TExpression Array { get; }

        IReadOnlyList<TArgument> Indexes { get; }
    }
}
