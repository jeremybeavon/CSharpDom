using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IDestructorWithSymbols : IDestructorWithSymbol, IHasDeclaringType<IClassDeclarationWithSymbols>,
        IHasSyntax<IDestructorSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
