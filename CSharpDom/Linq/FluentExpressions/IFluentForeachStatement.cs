using System;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentForeachStatement<T>
    {
        IFluentExpression Do(Action<T> statement);
    }
}
