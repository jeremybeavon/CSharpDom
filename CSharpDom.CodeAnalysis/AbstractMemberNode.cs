using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
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
