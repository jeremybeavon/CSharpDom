using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassNestedInterfaceCollection<TInterface, TPartialInterface> :
        IClassNestedInterfaceCollection,
        INestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IClassNestedInterface
        where TPartialInterface : IPartialInterface
    {
    }
}
