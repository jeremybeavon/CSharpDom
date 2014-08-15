using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public interface IClassDeclarationWithReflection : IClassWithSymbol, IHasType, IHasLocation,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasCompositeType<IClassWithReflection>,
        IHasDocument<IDocumentWithReflection>,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        ITypeWithReflection,
        IHasDestructor<IDestructorWithReflection>,
        IHasSyntax<IClassDeclarationSyntax>,
        IHasSymbols<IClassDeclarationWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
