using CSharpDom.BaseClasses.Editable.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class NestedStaticPartialClassMethodCollectionWithCodeAnalysis :
        EditableNestedStaticPartialClassMethodCollection<
            NestedStaticClassMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
    }
}
