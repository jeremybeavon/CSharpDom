namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentForWhileExpression
    {
        IFluentForIncrementExpression While();

        IFluentForIncrementExpression While(bool condition);
    }
}
