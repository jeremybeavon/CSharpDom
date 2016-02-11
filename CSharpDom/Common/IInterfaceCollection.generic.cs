using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IInterfaceCollection<TInterface, TPartialInterface> :
        IInterfaceCollection,
        IReadOnlyCollection<TInterface>,
        IHasPartialInterfaces<TPartialInterface>
        where TInterface : IInterface
        where TPartialInterface : IPartialInterface
    {
    }
}
