using CSharpDom.BaseClasses.Editable.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class SealedPartialClassMethodCollectionWithCodeAnalysis :
        EditableSealedPartialClassMethodCollection<
            SealedClassMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
    }
}
