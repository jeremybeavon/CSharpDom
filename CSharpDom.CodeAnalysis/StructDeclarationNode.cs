using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class StructDeclarationNode : MemberContainer<StructDeclarationSyntax>,
        ITypeModifier<StructDeclarationSyntax>
    {
        protected StructDeclarationNode(StructDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public StructNode StructNode { get; set; }

        public ITypeContainer DeclaringType
        {
            get { return Container; }
        }

        public sealed override ICompositeType CompositeType
        {
            get { return StructNode; }
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
            get
            {
                DocumentNode document = Document;
                return document == null ? null : document.Project;
            }
        }

        public SolutionNode Solution
        {
            get { return Project.Solution; }
        }

        public NamespaceNode Namespace
        {
            get { return StructNode.Namespace; }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public StructDeclarationSyntax WithMembers(StructDeclarationSyntax type, SyntaxList<MemberDeclarationSyntax> members)
        {
            return type.WithMembers(members);
        }

        public StructDeclarationSyntax WithAttributeLists(
            StructDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public StructDeclarationSyntax WithModifiers(StructDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }

        public StructDeclarationSyntax WithBaseList(StructDeclarationSyntax type, BaseListSyntax baseList)
        {
            return type.WithBaseList(baseList);
        }

        public StructDeclarationSyntax WithConstraintClauses(
            StructDeclarationSyntax type,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses)
        {
            return type.WithConstraintClauses(constraintClauses);
        }
    }
}
