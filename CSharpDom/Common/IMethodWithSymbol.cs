using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IMethodWithSymbol : IMethod, IHasSymbol<IMethodSymbol>
    {
    }
}
