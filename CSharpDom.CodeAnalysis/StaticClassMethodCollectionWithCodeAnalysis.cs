using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StaticClassMethodCollectionWithCodeAnalysis :
        EditableStaticClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis>
    {
    }
}
