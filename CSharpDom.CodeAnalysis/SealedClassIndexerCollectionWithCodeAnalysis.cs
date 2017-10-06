using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class SealedClassIndexerCollectionWithCodeAnalysis :
        EditableSealedClassIndexerCollection<
            SealedClassIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
    }
}
