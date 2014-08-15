using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class DestructorNode : AbstractNode<DestructorDeclarationSyntax, ClassDeclarationNode>,
        IMethodModifier<DestructorDeclarationSyntax>
    {
        protected DestructorNode(DestructorDeclarationSyntax declaration, ClassDeclarationNode container)
            : base(declaration, container)
        {
        }

        public ClassDeclarationNode DeclaringType
        {
            get { return Container; }
        }

        public bool IsNested
        {
            get { return DeclaringType.IsNestedType; }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public DestructorDeclarationSyntax WithAttributeLists(
            DestructorDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public DestructorDeclarationSyntax WithBody(DestructorDeclarationSyntax method, BlockSyntax body)
        {
            return method.WithBody(body);
        }

        public DestructorDeclarationSyntax WithModifiers(DestructorDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
