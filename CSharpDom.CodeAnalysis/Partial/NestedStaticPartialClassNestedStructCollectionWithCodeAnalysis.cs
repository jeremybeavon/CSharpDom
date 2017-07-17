using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<
            NestedStaticPartialClassNestedStructWithCodeAnalysis,
            NestedStaticPartialClassNestedPartialStructWithCodeAnalysis>
    {
    }
}
