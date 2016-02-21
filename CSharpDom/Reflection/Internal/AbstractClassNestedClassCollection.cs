using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection.Internal
{
    internal abstract class AbstractClassNestedClassCollection :
        AbstractClassNestedClassCollection<
            ClassNestedClassWithReflection,
            IClassNestedAbstractClass,
            IClassNestedSealedClass,
            IClassNestedStaticClass,
            PartialClassCollectionNotSupported>
    {
    }
}
