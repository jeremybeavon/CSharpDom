using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IFieldWithSymbol : IField, IHasSymbol<IFieldSymbol>
    {
    }
}
