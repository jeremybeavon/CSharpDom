using System;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentForStatement<T>
    {
        IFluentExpression Do(Func<T, Block> block);

        IFluentExpression Do(Action<T> statement);
    }
}
