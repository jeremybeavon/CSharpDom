using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax.Internal
{
    internal class MethodNodeWithSyntax : MethodNode, IMethodSyntax
    {
        public MethodNodeWithSyntax(MethodDeclarationSyntax declaration, IBasicMemberContainer container)
            : base(declaration, container)
        {
        }

        IBasicTypeSyntax IHasDeclaringType<IBasicTypeSyntax>.DeclaringType
        {
            get { return (IBasicTypeSyntax)DeclaringType; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return new MethodWithSyntax(this);
        }
    }
}
