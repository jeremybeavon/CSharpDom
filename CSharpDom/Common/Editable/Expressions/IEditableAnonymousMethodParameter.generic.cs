using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableAnonymousMethodParameter<TTypeReference> :
        IEditableAnonymousMethodParameter,
        IHasEditableName,
        IHasEditableModifier<AnonymousMethodParameterModifier>,
        IHasEditableParameterType<TTypeReference>,
        IAnonymousMethodParameter<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
    }
}