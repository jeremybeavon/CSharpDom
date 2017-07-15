using CSharpDom.Editable.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class StaticPartialClassMethodCollectionWithCodeAnalysis :
        EditableStaticPartialClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
    }
}
