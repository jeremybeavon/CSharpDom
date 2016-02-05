using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasProtectedOverrideEvents<TEvent>
    {
        IReadOnlyCollection<TEvent> ProtectedOverrideEvents { get; }
    }
}
