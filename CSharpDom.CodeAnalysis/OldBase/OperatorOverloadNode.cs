using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class OperatorOverloadNode : AbstractMemberNode<OperatorDeclarationSyntax>,
        IMethodModifier<OperatorDeclarationSyntax>
    {
        protected OperatorOverloadNode(OperatorDeclarationSyntax declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        public override string ToString()
        {
            return ToString(Declaration, this);
        }

        public OperatorDeclarationSyntax WithAttributeLists(
            OperatorDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public OperatorDeclarationSyntax WithBody(OperatorDeclarationSyntax method, BlockSyntax body)
        {
            return method.WithBody(body);
        }

        public OperatorDeclarationSyntax WithModifiers(OperatorDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
