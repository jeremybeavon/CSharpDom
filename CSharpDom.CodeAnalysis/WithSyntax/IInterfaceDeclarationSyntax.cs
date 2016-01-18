using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IInterfaceDeclarationSyntax :
        IInterface<INamespaceSyntax, IProjectSyntax, ISolutionSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax>,
        IHasLocation,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasCompositeType<IInterfaceSyntax>,
        IBasicTypeSyntax,
        IHasDocument<IDocumentSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
