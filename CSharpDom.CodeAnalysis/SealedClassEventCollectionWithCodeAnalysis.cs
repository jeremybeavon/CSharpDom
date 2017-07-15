using CSharpDom.Editable;

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
