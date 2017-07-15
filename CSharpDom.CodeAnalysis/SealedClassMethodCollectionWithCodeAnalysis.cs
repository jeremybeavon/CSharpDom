using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class SealedClassMethodCollectionWithCodeAnalysis :
        EditableSealedClassMethodCollection<
            SealedClassMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis>
    {
    }
}
