using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public interface IInterfaceDeclarationSyntax : IInterface, IHasLocation,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasCompositeType<IInterfaceSyntax>,
        IHasDocument<IDocumentSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>,
        IBasicTypeSyntax
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
