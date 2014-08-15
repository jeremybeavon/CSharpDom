using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IMethodWithSymbols : IMethodWithSymbol, IHasDeclaringType<IBasicTypeWithSymbols>,
        IHasSyntax<IMethodSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
