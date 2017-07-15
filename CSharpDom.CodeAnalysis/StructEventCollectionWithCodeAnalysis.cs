using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StructEventCollectionWithCodeAnalysis :
        EditableStructEventCollection<
            StructEventWithCodeAnalysis,
            StructEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
    }
}
