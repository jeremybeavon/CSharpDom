using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INamespaceSyntax :
        INamespace<IClassSyntax, IDelegateSyntax, IEnumSyntax, IInterfaceSyntax, IStructSyntax>,
        IHasDeclarations<NamespaceDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
