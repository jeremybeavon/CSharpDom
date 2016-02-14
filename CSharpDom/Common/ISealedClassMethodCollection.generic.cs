using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> :
        ISealedClassMethodCollection,
        IReadOnlyCollection<TMethod>,
        IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>
        where TMethod : ISealedClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
    }
}
