namespace CSharpDom.Common.Expressions
{
    public interface ITypeofExpression<TTypeReference> : ITypeofExpression
        where TTypeReference : ITypeReference
    {
        TTypeReference Type { get; }
    }
}
