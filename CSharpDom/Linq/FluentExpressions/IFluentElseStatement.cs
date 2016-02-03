using System;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentElseStatement : IFluentExpression
    {
        IFluentExpression Else(Block block);

        IFluentExpression Else(Action statement);

        IFluentExpression Else<T>(T statement);

        IFluentIfStatement ElseIf(bool condition);
    }
}
