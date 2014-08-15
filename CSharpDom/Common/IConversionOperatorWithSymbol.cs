using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IConversionOperatorWithSymbol : IConversionOperator, IHasSymbol<IMethodSymbol>
    {
    }
}
