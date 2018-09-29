namespace CSharpDom.Common.Expressions
{
    public interface IGenericMemberExpression<TExpression, TTypeReference> :
        IGenericMemberExpression,
        IHasGenericParameters<TTypeReference>
        where TExpression : IExpression
        where TTypeReference : ITypeReference
    {
        TExpression ObjectExpression { get; }

        string MemberName { get; }
    }
}
