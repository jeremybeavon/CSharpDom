using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StructNestedClassCollectionWithCodeAnalysis :
        EditableStructNestedClassCollection<
            StructNestedClassWithCodeAnalysis,
            StructNestedAbstractClassWithCodeAnalysis,
            StructNestedSealedClassWithCodeAnalysis,
            StructNestedStaticClassWithCodeAnalysis,
            StructNestedPartialClassCollectionWithCodeAnalysis>
    {
    }
}
