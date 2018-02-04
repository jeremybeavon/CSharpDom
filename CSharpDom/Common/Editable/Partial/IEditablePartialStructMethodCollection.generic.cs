using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditablePartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        IEditablePartialStructMethodCollection,
        IEditableStructMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IHasEditablePartialMethodDefinitions<TPartialMethodDefinition>,
        IHasEditablePartialMethodImplementations<TPartialMethodImplementation>,
        IPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IEditableStructMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
        where TPartialMethodDefinition : IEditablePartialMethodDefinition
        where TPartialMethodImplementation : IEditablePartialMethodImplementation
    {
    }
}