using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IOperatorOverloadWithSymbol : IOperatorOverload, IHasSymbol<IMethodSymbol>
    {
    }
}
