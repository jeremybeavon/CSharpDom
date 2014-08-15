using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IPropertyWithSymbol : IProperty, IHasSymbol<IPropertySymbol>
    {
    }
}
