using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StructPropertyCollectionWithCodeAnalysis :
        EditableStructPropertyCollection<
            StructPropertyWithCodeAnalysis,
            StructAutoPropertyWithCodeAnalysis,
            StructLambdaPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
    }
}
