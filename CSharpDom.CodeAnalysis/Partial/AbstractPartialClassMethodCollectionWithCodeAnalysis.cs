using CSharpDom.Editable.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class AbstractPartialClassMethodCollectionWithCodeAnalysis :
        EditableAbstractPartialClassMethodCollection<
            ClassMethodWithCodeAnalysis,
            AbstractMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
    }
}
