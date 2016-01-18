using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class EventPropertyNodeWithSyntax : EventPropertyNode, IEventPropertySyntax
    {
        public EventPropertyNodeWithSyntax(EventDeclarationSyntax declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        ITypeSyntax IHasDeclaringType<ITypeSyntax>.DeclaringType
        {
            get { return (ITypeSyntax)DeclaringType; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return new EventPropertyWithSyntax(this);
        }
    }
}
