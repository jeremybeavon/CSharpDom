using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedInterfaceDeclarationSyntax :
        INestedInterface<ITypeSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax>,
        IBasicTypeSyntax,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasCompositeType<INestedInterfaceSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
