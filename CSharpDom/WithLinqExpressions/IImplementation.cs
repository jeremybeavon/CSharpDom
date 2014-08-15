using System.Linq.Expressions;

namespace CSharpDom.WithLinqExpressions
{
    public interface IImplementation
    {
        LambdaExpression Expression { get; }

        BlockStatement Body { get; }
    }
}
