using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditableNestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        IEditableNestedStaticPartialClassMethodCollection,
        IEditableNestedStaticClassMethodCollection<TMethod>,
        IHasEditablePartialMethodDefinitions<TPartialMethodDefinition>,
        IHasEditablePartialMethodImplementations<TPartialMethodImplementation>,
        INestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IEditableStaticClassMethod
        where TPartialMethodDefinition : IEditablePartialMethodDefinition
        where TPartialMethodImplementation : IEditablePartialMethodImplementation
    {
    }
}