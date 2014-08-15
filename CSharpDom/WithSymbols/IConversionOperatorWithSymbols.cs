using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IConversionOperatorWithSymbols : IConversionOperatorWithSymbol, IHasDeclaringType<ITypeWithSymbols>,
        IHasSyntax<IConversionOperatorSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
