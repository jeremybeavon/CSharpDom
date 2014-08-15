using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IFieldWithSymbols : IFieldWithSymbol, IHasDeclaringType<ITypeWithSymbols>,
        IHasSyntax<IFieldSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
