using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis
{
    public interface IInterfaceTypeWithCodeAnalysis :
        IInterfaceType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>
    {
    }
}
