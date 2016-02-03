namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentForWhileExpression<T>
    {
        IFluentForIncrementExpression<T> While();

        IFluentForIncrementExpression<T> While(bool condition);
    }
}
