using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassMethodCollection<TMethod, TProtectedOverrideMethod, TExplicitInterfaceMethod> :
        ISealedClassMethodCollection,
        IReadOnlyCollection<TMethod>,
        IHasProtectedOverrideMethods<TProtectedOverrideMethod>,
        IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>
        where TMethod : ISealedClassMethod
        where TProtectedOverrideMethod : IProtectedOverrideMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
    }
}
