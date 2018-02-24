namespace CSharpDom.Common.Expressions
{
    public interface IRefArgument<TExpression> : IRefArgument, IArgument<TExpression>
        where TExpression : IExpression
    {
    }
}
