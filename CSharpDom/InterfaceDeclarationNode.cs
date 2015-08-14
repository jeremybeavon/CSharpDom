using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class InterfaceDeclarationNode : BasicMemberContainer<InterfaceDeclarationSyntax>,
        ITypeModifier<InterfaceDeclarationSyntax>
    {
        protected InterfaceDeclarationNode(InterfaceDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public InterfaceNode InterfaceNode { get; set; }

        public ITypeContainer DeclaringType
        {
            get { return Container; }
        }

        public IBasicCompositeType CompositeType
        {
            get { return BasicCompositeType; }
        }

        public sealed override IBasicCompositeType BasicCompositeType
        {
            get { return InterfaceNode; }
        }

        public DocumentNode Document
        {
            get { return Container as DocumentNode; }
        }

        public bool IsGeneric
        {
            get { return GenericParameterCount != 0; }
        }

        public ProjectNode Project
        {
            get { return Document.Project; }
        }

        public SolutionNode Solution
        {
            get { return Document.Solution; }
        }

        public NamespaceNode Namespace
        {
            get { return InterfaceNode.Namespace; }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public InterfaceDeclarationSyntax WithMembers(
            InterfaceDeclarationSyntax type,
            SyntaxList<MemberDeclarationSyntax> members)
        {
            return type.WithMembers(members);
        }

        public InterfaceDeclarationSyntax WithAttributeLists(
            InterfaceDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public InterfaceDeclarationSyntax WithModifiers(InterfaceDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }

        public InterfaceDeclarationSyntax WithBaseList(InterfaceDeclarationSyntax type, BaseListSyntax baseList)
        {
            return type.WithBaseList(baseList);
        }

        public InterfaceDeclarationSyntax WithConstraintClauses(
            InterfaceDeclarationSyntax type,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses)
        {
            return type.WithConstraintClauses(constraintClauses);
        }
    }
}
