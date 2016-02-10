using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassMethodCollection<TMethod, TExplicitInterfaceMethod> :
        IClassMethodCollection,
        IReadOnlyCollection<TMethod>,
        IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>
        where TMethod : IClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
    }
}
