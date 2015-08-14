using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IDelegateWithSymbol : IDelegate, IHasSymbol<INamedTypeSymbol>
    {
    }
}
