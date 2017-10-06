using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class AbstractClassPropertyCollectionWithCodeAnalysis :
        EditableAbstractClassPropertyCollection<
            AbstractClassPropertyWithCodeAnalysis,
            AbstractPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
    }
}
