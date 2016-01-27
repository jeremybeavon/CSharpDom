using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IInterfaceSyntax :
        IInterface<INamespaceSyntax, IProjectSyntax, ISolutionSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax>,
        IBasicTypeSyntax,
        IHasDeclarations<IInterfaceDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
