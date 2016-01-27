using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface INestedDestructorWithSymbols :
        IDestructor<INestedClassWithSymbols>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<INestedDestructorSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
