using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class AbstractClassIndexerCollectionWithCodeAnalysis :
        EditableAbstractClassIndexerCollection<
            AbstractClassIndexerWithCodeAnalysis,
            AbstractIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
    }
}
