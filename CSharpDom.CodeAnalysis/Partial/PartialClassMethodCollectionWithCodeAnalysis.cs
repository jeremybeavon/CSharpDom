using CSharpDom.BaseClasses.Editable.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class PartialClassMethodCollectionWithCodeAnalysis :
        EditablePartialClassMethodCollection<
            ClassMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
    }
}
