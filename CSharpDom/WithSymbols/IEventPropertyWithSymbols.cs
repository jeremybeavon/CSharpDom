using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IEventPropertyWithSymbols : IEventPropertyWithSymbol, IHasDeclaringType<ITypeWithSymbols>,
        IHasSyntax<IEventPropertySyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
