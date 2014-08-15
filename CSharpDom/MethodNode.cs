using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class MethodNode : AbstractBasicMemberNode<MethodDeclarationSyntax>,
        IMethodModifier<MethodDeclarationSyntax>
    {
        protected MethodNode(MethodDeclarationSyntax declaration, IBasicMemberContainer container)
            : base(declaration, container)
        {
        }

        public bool IsGeneric
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int GenericParameterCount
        {
            get { return 0; }
        }

        public string Name
        {
            get { return Declaration.Identifier.ToString(); }
        }

        MethodDeclarationSyntax IMemberModifier<MethodDeclarationSyntax>.Declaration
        {
            get { return Declaration.WithConstraintClauses(new SyntaxList<TypeParameterConstraintClauseSyntax>()); }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public MethodDeclarationSyntax WithAttributeLists(
            MethodDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public MethodDeclarationSyntax WithBody(MethodDeclarationSyntax method, BlockSyntax body)
        {
            return method.WithBody(body);
        }

        public MethodDeclarationSyntax WithModifiers(MethodDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
