using CSharpDom.BaseClasses.Editable;

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
