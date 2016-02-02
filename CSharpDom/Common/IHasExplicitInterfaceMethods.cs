using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>
    {
        IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; }
    }
}
