using CSharpDom.Editable.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class NestedStaticPartialClassMethodCollectionWithCodeAnalysis :
        EditableNestedStaticPartialClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
    }
}
