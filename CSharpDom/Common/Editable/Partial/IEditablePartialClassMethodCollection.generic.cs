using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditablePartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        IEditablePartialClassMethodCollection,
        IEditableClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IHasEditablePartialMethodDefinitions<TPartialMethodDefinition>,
        IHasEditablePartialMethodImplementations<TPartialMethodImplementation>,
        IPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IEditableClassMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
        where TPartialMethodDefinition : IEditablePartialMethodDefinition
        where TPartialMethodImplementation : IEditablePartialMethodImplementation
    {
    }
}