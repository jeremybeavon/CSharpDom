namespace CSharpDom.Common.Expressions
{
    public interface IArgument<TExpression> : IArgument, IHasName
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
