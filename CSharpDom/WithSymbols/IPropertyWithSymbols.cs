using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IPropertyWithSymbols : IPropertyWithSymbol, IHasDeclaringType<IBasicTypeWithSymbols>,
        IHasSyntax<IPropertySyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
