using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;

namespace CSharpDom.CodeAnalysis
{
    public abstract class NestedStaticClassNestedClassCollectionWithCodeAnalysis :
        EditableStaticClassNestedClassCollection<
            NestedStaticClassNestedClassWithCodeAnalysis,
            NestedStaticClassNestedAbstractClassWithCodeAnalysis,
            NestedStaticClassNestedSealedClassWithCodeAnalysis,
            NestedStaticClassNestedStaticClassWithCodeAnalysis,
            NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis>
    {
    }
}
