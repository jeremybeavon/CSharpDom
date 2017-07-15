using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class SealedClassIndexerCollectionWithCodeAnalysis :
        EditableSealedClassIndexerCollection<
            SealedClassIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
    }
}
