using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface INestedDelegateWithSymbols : IDelegateWithSymbol, IHasDeclaringType<ITypeWithSymbols>,
        IHasSyntax<INestedDelegateSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
