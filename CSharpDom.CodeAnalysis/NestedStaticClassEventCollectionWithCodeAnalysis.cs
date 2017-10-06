using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class NestedStaticClassEventCollectionWithCodeAnalysis :
        EditableStaticClassEventCollection<
            NestedStaticClassEventWithCodeAnalysis,
            NestedStaticClassEventPropertyWithCodeAnalysis>
    {
    }
}
