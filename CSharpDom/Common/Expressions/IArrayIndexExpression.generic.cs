using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IArrayIndexExpression<TExpression> : IArrayIndexExpression
		where TExpression : IExpression
    {
        TExpression Array { get; }

        IReadOnlyList<TExpression> Indexes { get; }
    }
}
