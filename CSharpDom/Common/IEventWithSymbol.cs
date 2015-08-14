using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IEventWithSymbol : IEvent, IHasSymbol<IEventSymbol>
    {
    }
}
