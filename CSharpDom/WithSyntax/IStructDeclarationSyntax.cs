using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public interface IStructDeclarationSyntax : IStruct, IHasLocation,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasCompositeType<IStructSyntax>,
        IHasDocument<IDocumentSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>,
        ITypeSyntax
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
