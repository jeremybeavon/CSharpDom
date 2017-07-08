namespace CSharpDom.Common.Expressions
{
    public interface IAnonymousMethodParameter<TTypeReference> :
        IAnonymousMethodParameter,
        IHasName,
        IHasModifier<AnonymousMethodParameterModifier>,
        IHasParameterType<TTypeReference>
        where TTypeReference : ITypeReference
    {
    }
}
