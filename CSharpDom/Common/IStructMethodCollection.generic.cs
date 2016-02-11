using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructMethodCollection<TMethod, TExplicitInterfaceMethod> :
        IStructMethodCollection,
        IReadOnlyCollection<TMethod>,
        IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>
        where TMethod : IStructMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
    }
}
