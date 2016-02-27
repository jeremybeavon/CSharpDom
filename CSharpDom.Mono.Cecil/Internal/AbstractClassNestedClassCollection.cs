using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal abstract class AbstractClassNestedClassCollection :
        AbstractClassNestedClassCollection<
            ClassNestedClassWithMonoCecil,
            ClassNestedAbstractClassWithMonoCecil,
            ClassNestedSealedClassWithMonoCecil,
            ClassNestedStaticClassWithMonoCecil,
            PartialClassCollectionNotSupported>
    {
    }
}
