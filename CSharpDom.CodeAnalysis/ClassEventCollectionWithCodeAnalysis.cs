using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class ClassEventCollectionWithCodeAnalysis :
        EditableClassEventCollection<
            ClassEventWithCodeAnalysis,
            ClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
    }
}
