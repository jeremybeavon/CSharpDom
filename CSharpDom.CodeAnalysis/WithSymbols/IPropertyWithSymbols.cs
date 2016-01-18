using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IPropertyWithSymbols :
        IProperty<IBasicTypeWithSymbols>,
        IHasSymbol<IPropertySymbol>,
        IHasSyntax<IPropertySyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
