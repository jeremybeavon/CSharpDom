using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IEventPropertyWithSymbol : IEventProperty, IHasSymbol<IEventSymbol>
    {
    }
}
