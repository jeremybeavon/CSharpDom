using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IConstructorWithSymbols : IConstructorWithSymbol, IHasDeclaringType<ITypeWithSymbols>,
        IHasSyntax<IConstructorSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
