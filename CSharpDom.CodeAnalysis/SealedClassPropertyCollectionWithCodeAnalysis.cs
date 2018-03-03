using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class SealedClassPropertyCollectionWithCodeAnalysis :
        EditableSealedClassPropertyCollection<
            SealedClassPropertyWithCodeAnalysis,
            SealedClassAutoPropertyWithCodeAnalysis,
            SealedClassLambdaPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
    }
}
