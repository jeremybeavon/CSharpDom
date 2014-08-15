using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IStructWithSymbol : IStruct, IHasSymbol<INamedTypeSymbol>
    {
    }
}
