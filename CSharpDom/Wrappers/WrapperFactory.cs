using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Wrappers
{
    public static class WrapperFactory
    {
        public static IClassPropertyCollectionWrapper CreateClassPropertyCollectionWrapper(IClassPropertyCollection propertyCollection)
        {
            return new ClassPropertyCollectionWrapper(propertyCollection);
        }
    }
}
