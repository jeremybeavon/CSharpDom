using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers
{
    public interface IClassNestedInterfaceCollectionWrapper :
        IClassNestedInterfaceCollection<IClassNestedInterfaceWrapper, IPartialInterface>
    {
    }
}
