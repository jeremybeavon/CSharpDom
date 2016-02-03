using System;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentUsingExpression<T>
    {
        IFluentExpression Do(Action action);

        IFluentExpression Do(Block block);

        IFluentExpression Do(Action<T> action);

        IFluentExpression Do<TReturn>(TReturn statement);


    }
}
