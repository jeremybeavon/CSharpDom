using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IClassDeclarationWithLinqExpressions : IClassWithSymbol, IHasType, IHasLocation,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasCompositeType<IClassWithLinqExpressions>,
        IHasDocument<IDocumentWithLinqExpressions>,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        ITypeWithLinqExpressions,
        IHasDestructor<IDestructorWithLinqExpressions>,
        IHasSyntax<IClassDeclarationSyntax>,
        IHasSymbols<IClassDeclarationWithSymbols>,
        IHasReflection<IClassDeclarationWithReflection>
    {
    }
}
