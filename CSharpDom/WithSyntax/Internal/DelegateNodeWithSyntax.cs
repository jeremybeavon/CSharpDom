using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax.Internal
{
    internal class DelegateNodeWithSyntax : DelegateNode, IDelegateSyntax, INestedDelegateSyntax
    {
        public DelegateNodeWithSyntax(DelegateDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        ITypeSyntax IHasDeclaringType<ITypeSyntax>.DeclaringType
        {
            get { return (ITypeSyntax)DeclaringType; }
        }

        INamespaceSyntax IHasNamespace<INamespaceSyntax>.Namespace
        {
            get { return (INamespaceSyntax)Namespace; }
        }

        IProjectSyntax IHasProject<IProjectSyntax>.Project
        {
            get { return (IProjectSyntax)Project; }
        }

        ISolutionSyntax IHasSolution<ISolutionSyntax>.Solution
        {
            get { return (ISolutionSyntax)Solution; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return new DelegateWithSyntax(this);
        }
    }
}
