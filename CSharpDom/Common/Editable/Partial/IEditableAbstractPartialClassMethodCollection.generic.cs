using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditableAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        IEditableAbstractPartialClassMethodCollection,
        IEditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>,
        IHasEditablePartialMethodDefinitions<TPartialMethodDefinition>,
        IHasEditablePartialMethodImplementations<TPartialMethodImplementation>,
        IAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IEditableClassMethod
        where TAbstractMethod : IEditableAbstractMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
        where TPartialMethodDefinition : IEditablePartialMethodDefinition
        where TPartialMethodImplementation : IEditablePartialMethodImplementation
    {
    }
}