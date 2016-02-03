using System;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentWhileStatement
    {
        IFluentExpression Do(Block block);

        IFluentExpression Do(Action statement);
    }
}
