using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis
{
    public interface IClassTypeDefinitionWithCodeAnalysis :
        IClassTypeDefinition<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis>
    {
    }
}
