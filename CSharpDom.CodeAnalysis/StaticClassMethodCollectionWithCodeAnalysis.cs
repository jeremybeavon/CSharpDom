using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StaticClassMethodCollectionWithCodeAnalysis :
        EditableStaticClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis>
    {
    }
}
