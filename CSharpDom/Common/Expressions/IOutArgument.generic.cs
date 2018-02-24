namespace CSharpDom.Common.Expressions
{
    public interface IOutArgument<TExpression> : IOutArgument, IArgument<TExpression>
        where TExpression : IExpression
    {
    }
}
