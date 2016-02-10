using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> :
        IAbstractClassMethodCollection,
        IReadOnlyCollection<TMethod>,
        IHasAbstractMethods<TAbstractMethod>,
        IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>
        where TMethod : IClassMethod
        where TAbstractMethod : IAbstractMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
    }
}
