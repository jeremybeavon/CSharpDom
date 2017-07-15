using CSharpDom.Common.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public interface IClassNestedPartialClassCollectionWithCodeAnalysis :
        IPartialClassCollection<
            ClassNestedPartialClassWithCodeAnalysis,
            ClassNestedAbstractPartialClassWithCodeAnalysis,
            ClassNestedSealedPartialClassWithCodeAnalysis,
            ClassNestedStaticPartialClassWithCodeAnalysis>
    {
    }
}
