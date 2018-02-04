using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditableSealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        IEditableSealedPartialClassMethodCollection,
        IEditableSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IHasEditablePartialMethodDefinitions<TPartialMethodDefinition>,
        IHasEditablePartialMethodImplementations<TPartialMethodImplementation>,
        ISealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
        where TMethod : IEditableSealedClassMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
        where TPartialMethodDefinition : IEditablePartialMethodDefinition
        where TPartialMethodImplementation : IEditablePartialMethodImplementation
    {
    }
}