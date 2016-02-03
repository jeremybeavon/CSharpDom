namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentAssignStatement<T>
    {
        IFluentExpression To(T value);
    }
}
