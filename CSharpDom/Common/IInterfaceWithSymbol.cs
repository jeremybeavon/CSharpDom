using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IInterfaceWithSymbol : IInterface, IHasSymbol<INamedTypeSymbol>
    {
    }
}
