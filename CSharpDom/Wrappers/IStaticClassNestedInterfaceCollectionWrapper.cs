using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassNestedInterfaceCollectionWrapper :
        IStaticClassNestedInterfaceCollection<IStaticClassNestedInterfaceWrapper, IPartialInterface>
    {
    }
}
