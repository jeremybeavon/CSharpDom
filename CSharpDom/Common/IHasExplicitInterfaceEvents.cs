using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
    {
        IReadOnlyCollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; }
    }
}
