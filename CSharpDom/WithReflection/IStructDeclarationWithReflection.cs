using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public interface IStructDeclarationWithReflection : IStructWithSymbol, IHasType, IHasLocation,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasCompositeType<IStructWithReflection>,
        IHasDocument<IDocumentWithReflection>,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        ITypeWithReflection,
        IHasSyntax<IStructDeclarationSyntax>,
        IHasSymbols<IStructDeclarationWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
