using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public interface IInterfaceDeclarationWithReflection : IInterfaceWithSymbol, IHasType, IHasLocation,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasCompositeType<IInterfaceWithReflection>,
        IHasDocument<IDocumentWithReflection>,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        IBasicTypeWithReflection,
        IHasSyntax<IInterfaceDeclarationSyntax>, 
        IHasSymbols<IInterfaceDeclarationWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
