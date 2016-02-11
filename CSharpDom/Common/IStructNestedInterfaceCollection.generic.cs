using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructNestedInterfaceCollection<TInterface, TPartialInterface> :
        IStructNestedInterfaceCollection,
        INestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IStructNestedInterface
        where TPartialInterface : IPartialInterface
    {
    }
}
