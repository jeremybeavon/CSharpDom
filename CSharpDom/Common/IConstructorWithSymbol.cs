using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IConstructorWithSymbol : IConstructor, IHasSymbol<IMethodSymbol>
    {
    }
}
