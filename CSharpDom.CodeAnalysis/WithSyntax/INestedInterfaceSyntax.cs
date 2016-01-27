using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedInterfaceSyntax :
        INestedInterface<ITypeSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax>,
        IBasicTypeSyntax,
        IHasDeclarations<INestedInterfaceDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
