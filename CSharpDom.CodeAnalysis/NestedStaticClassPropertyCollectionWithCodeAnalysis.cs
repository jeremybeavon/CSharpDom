using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class NestedStaticClassPropertyCollectionWithCodeAnalysis :
        EditableStaticClassPropertyCollection<
            NestedStaticClassPropertyWithCodeAnalysis,
            NestedStaticClassAutoPropertyWithCodeAnalysis,
            NestedStaticClassLambdaPropertyWithCodeAnalysis>
    {
    }
}
