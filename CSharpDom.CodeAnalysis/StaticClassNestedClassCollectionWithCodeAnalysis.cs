using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StaticClassNestedClassCollectionWithCodeAnalysis :
        EditableStaticClassNestedClassCollection<
            StaticClassNestedClassWithCodeAnalysis,
            StaticClassNestedAbstractClassWithCodeAnalysis,
            StaticClassNestedSealedClassWithCodeAnalysis,
            StaticClassNestedStaticClassWithCodeAnalysis,
            StaticClassNestedPartialClassCollectionWithCodeAnalysis>
    {
    }
}
