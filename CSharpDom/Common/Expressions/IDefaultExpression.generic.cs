namespace CSharpDom.Common.Expressions
{
    public interface IDefaultExpression<TTypeReference> : IDefaultExpression
        where TTypeReference : ITypeReference
    {
        TTypeReference Type { get; }
    }
}
