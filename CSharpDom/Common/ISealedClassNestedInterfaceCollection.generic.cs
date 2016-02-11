using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassNestedInterfaceCollection<TInterface, TPartialInterface> :
        ISealedClassNestedInterfaceCollection,
        INestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : ISealedClassNestedInterface
        where TPartialInterface : IPartialInterface
    {
    }
}
