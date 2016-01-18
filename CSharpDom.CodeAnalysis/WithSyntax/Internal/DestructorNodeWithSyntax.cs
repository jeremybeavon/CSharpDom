using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class DestructorNodeWithSyntax : DestructorNode, IDestructorSyntax, INestedDestructorSyntax
    {
        public DestructorNodeWithSyntax(DestructorDeclarationSyntax declaration, ClassDeclarationNode container)
            : base(declaration, container)
        {
        }

        INestedClassDeclarationSyntax IHasDeclaringType<INestedClassDeclarationSyntax>.DeclaringType
        {
            get { return (INestedClassDeclarationSyntax)DeclaringType; }
        }

        IClassDeclarationSyntax IHasDeclaringType<IClassDeclarationSyntax>.DeclaringType
        {
            get { return (IClassDeclarationSyntax)DeclaringType; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return IsNested ? (AbstractSyntaxNode)new NestedDestructorWithSyntax(this) : new DestructorWithSyntax(this);
        }
    }
}
