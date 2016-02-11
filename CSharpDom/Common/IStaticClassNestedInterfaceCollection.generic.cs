using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStaticClassNestedInterfaceCollection<TInterface, TPartialInterface> :
        IStaticClassNestedInterfaceCollection,
        INestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IStaticClassNestedInterface
        where TPartialInterface : IPartialInterface
    {
    }
}
