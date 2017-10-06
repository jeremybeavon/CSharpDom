using CSharpDom.BaseClasses.Editable;

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
