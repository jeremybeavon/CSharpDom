namespace CSharpDom.Common.Expressions
{
    public interface IMemberExpression<TExpression> : IMemberExpression
        where TExpression : IExpression
    {
        TExpression ObjectExpression { get; }

        string MemberName { get; }
    }
}
