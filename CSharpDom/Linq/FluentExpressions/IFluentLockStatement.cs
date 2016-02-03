using System;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentLockStatement
    {
        IFluentExpression For(Action action);

        IFluentExpression For(Block block);
    }
}
