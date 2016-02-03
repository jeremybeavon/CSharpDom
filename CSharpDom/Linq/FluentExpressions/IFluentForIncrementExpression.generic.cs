using System;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentForIncrementExpression<T>
    {
        IFluentForStatement<T> Increment(params Action<T>[] actions);
    }
}
