using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class SealedClassEventCollectionWithCodeAnalysis :
        EditableSealedClassEventCollection<
            SealedClassEventWithCodeAnalysis,
            SealedClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
    }
}
