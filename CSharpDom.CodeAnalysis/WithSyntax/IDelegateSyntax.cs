using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IDelegateSyntax :
        IDelegate<INamespaceSyntax, IProjectSyntax, ISolutionSyntax>,
        IHasDeclaration<DelegateDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
