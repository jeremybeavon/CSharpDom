using System;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentForIncrementExpression
    {
        IFluentForStatement Increment(params Action[] actions);
    }
}
