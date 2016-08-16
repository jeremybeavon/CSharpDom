using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal abstract class AbstractClassNestedClassCollection :
        AbstractClassNestedClassCollection<
            ClassNestedClassWithCodeAnalysis,
            ClassNestedAbstractClassWithCodeAnalysis,
            ClassNestedSealedClassWithCodeAnalysis,
            ClassNestedStaticClassWithCodeAnalysis,
            PartialClassCollectionNotSupported>
    {
    }
}
