using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IInterfaceDeclarationWithLinqExpressions : IInterfaceWithSymbol, IHasType, IHasLocation,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasCompositeType<IInterfaceWithLinqExpressions>,
        IHasDocument<IDocumentWithLinqExpressions>,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        IBasicTypeWithLinqExpressions,
        IHasSyntax<IInterfaceDeclarationSyntax>, 
        IHasSymbols<IInterfaceDeclarationWithSymbols>,
        IHasReflection<IInterfaceDeclarationWithReflection>
    {
    }
}
