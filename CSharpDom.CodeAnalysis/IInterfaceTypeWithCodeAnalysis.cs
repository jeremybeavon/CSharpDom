using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.CodeAnalysis
{
    public interface IInterfaceTypeWithCodeAnalysis :
        IEditableInterfaceType,
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
