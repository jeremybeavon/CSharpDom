using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IOperatorOverloadWithSymbols : IOperatorOverloadWithSymbol, IHasDeclaringType<ITypeWithSymbols>,
        IHasSyntax<IOperatorOverloadSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
