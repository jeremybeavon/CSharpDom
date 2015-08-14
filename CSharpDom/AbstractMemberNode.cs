using Microsoft.CodeAnalysis;

namespace CSharpDom
{
    internal abstract class AbstractMemberNode<TDeclaration> : AbstractNode<TDeclaration, IMemberContainer>
        where TDeclaration : SyntaxNode
    {
        protected AbstractMemberNode(TDeclaration declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        public ICompositeType DeclaringType
        {
            get { return Container.CompositeType; }
        }
    }
}
