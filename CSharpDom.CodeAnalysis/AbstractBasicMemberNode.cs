using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class AbstractBasicMemberNode<TDeclaration> : AbstractNode<TDeclaration, IBasicMemberContainer>
        where TDeclaration : SyntaxNode
    {
        protected AbstractBasicMemberNode(TDeclaration declaration, IBasicMemberContainer container)
            : base(declaration, container)
        {
        }

        public IBasicCompositeType DeclaringType
        {
            get { return Container.BasicCompositeType; }
        }
    }
}
