using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public interface IClassDeclarationWithSymbols : IClassWithSymbol, IHasLocation,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasCompositeType<IClassWithSymbols>,
        IHasDocument<IDocumentWithSymbols>,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        ITypeWithSymbols,
        IHasDestructor<IDestructorWithSymbols>,
        IHasSyntax<IClassDeclarationSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
