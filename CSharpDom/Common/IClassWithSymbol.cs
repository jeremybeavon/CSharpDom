using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IClassWithSymbol : IClass, IHasSymbol<INamedTypeSymbol>
    {
    }
}
