using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IStructDeclarationWithLinqExpressions : IStructWithSymbol, IHasType, IHasLocation,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasCompositeType<IStructWithLinqExpressions>,
        IHasDocument<IDocumentWithLinqExpressions>,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        ITypeWithLinqExpressions,
        IHasSyntax<IStructDeclarationSyntax>,
        IHasSymbols<IStructDeclarationWithSymbols>,
        IHasReflection<IStructDeclarationWithReflection>
    {
    }
}
