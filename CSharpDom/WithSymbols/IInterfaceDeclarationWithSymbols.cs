using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public interface IInterfaceDeclarationWithSymbols : IInterfaceWithSymbol, IHasLocation,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasCompositeType<IInterfaceWithSymbols>,
        IHasDocument<IDocumentWithSymbols>,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        IBasicTypeWithSymbols,
        IHasSyntax<IInterfaceDeclarationSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
