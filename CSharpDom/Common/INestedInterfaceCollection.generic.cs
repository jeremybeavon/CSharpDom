using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface INestedInterfaceCollection<TInterface, TPartialInterface> :
        INestedInterfaceCollection,
        IReadOnlyCollection<TInterface>,
        IHasPartialInterfaces<TPartialInterface>
        where TInterface : INestedInterface
        where TPartialInterface : IPartialInterface
    {
    }
}
