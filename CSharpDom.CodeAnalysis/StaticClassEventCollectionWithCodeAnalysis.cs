using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StaticClassEventCollectionWithCodeAnalysis :
        EditableStaticClassEventCollection<
            StaticClassEventWithCodeAnalysis,
            StaticClassEventPropertyWithCodeAnalysis>
    {
    }
}
