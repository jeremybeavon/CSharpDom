using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public interface INestedDestructorWithSymbols : IDestructor, IHasDeclaringType<INestedClassDeclarationWithSymbols>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<INestedDestructorSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
