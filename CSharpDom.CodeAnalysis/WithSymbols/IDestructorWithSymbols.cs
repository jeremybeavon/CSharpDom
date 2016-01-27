using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IDestructorWithSymbols :
        IDestructor<IClassWithSymbols>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<IDestructorSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
