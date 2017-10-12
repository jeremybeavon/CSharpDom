using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public interface IClassTypeDefinitionWithReflection :
        IClassTypeDefinition<
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection>
    {
    }
}
