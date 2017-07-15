using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class AbstractClassMethodCollectionWithCodeAnalysis :
        EditableAbstractClassMethodCollection<
            AbstractClassMethodWithCodeAnalysis,
            AbstractMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis>
    {
    }
}
