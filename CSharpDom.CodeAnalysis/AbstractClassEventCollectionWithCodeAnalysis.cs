using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class AbstractClassEventCollectionWithCodeAnalysis :
        EditableAbstractClassEventCollection<
            AbstractClassEventWithCodeAnalysis,
            AbstractClassEventPropertyWithCodeAnalysis,
            AbstractEventWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
    }
}
