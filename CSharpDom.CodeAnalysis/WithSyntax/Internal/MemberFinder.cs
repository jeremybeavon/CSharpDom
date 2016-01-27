using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal sealed class MemberFinder : NodeVisitor
    {
        private readonly SyntaxNode syntaxNode;

        public MemberFinder(SyntaxNode syntaxNode)
        {
            this.syntaxNode = syntaxNode;
        }

        public AbstractNode MatchedNode { get; private set; }

        public override void DefaultVisit(AbstractNode node)
        {
            IHasSyntaxNode declaration = node as IHasSyntaxNode;
            if (declaration != null && declaration.SyntaxNode == syntaxNode)
            {
                MatchedNode = node;
            }
            else if (MatchedNode == null)
            {
                base.DefaultVisit(node);
            }
        }
    }
}
