using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasEvents<TEvent>
    {
        IReadOnlyCollection<TEvent> Events { get; }
    }
}
