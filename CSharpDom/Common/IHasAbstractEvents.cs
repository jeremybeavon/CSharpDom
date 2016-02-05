using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasAbstractEvents<TEvent>
    {
        IReadOnlyCollection<TEvent> AbstractEvents { get; }
    }
}
