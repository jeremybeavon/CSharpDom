using System;
using System.Collections.ObjectModel;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class EnumNode : AbstractNode<EnumDeclarationSyntax, ITypeContainer>,
        ITypeModifier<EnumDeclarationSyntax>
    {
        protected EnumNode(EnumDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
            EnumMembers = new Collection<EnumMemberNode>();
        }

        public Collection<EnumMemberNode> EnumMembers { get; private set; }

        public string Name
        {
            get { return Declaration.Identifier.ToString(); }
        }

        public bool IsNestedType
        {
            get { return Namespace == null; }
        }

        public ITypeContainer DeclarationTypeContainer { get; set; }

        public ICompositeType DeclaringType
        {
            get
            {
                IHasCompositeType hasCompositeType = Container as IHasCompositeType;
                return hasCompositeType == null ? null : hasCompositeType.CompositeType;
            }
        }

        public NamespaceNode Namespace
        {
            get { return Container as NamespaceNode; }
        }

        public ProjectNode Project
        {
            get { return ((IHasProject<ProjectNode>)DeclarationTypeContainer).Project; }
        }

        public SolutionNode Solution
        {
            get { return Project.Solution; }
        }

        EnumDeclarationSyntax IMemberModifier<EnumDeclarationSyntax>.Declaration
        {
            get { return Declaration.WithMembers(new SeparatedSyntaxList<EnumMemberDeclarationSyntax>()); }
        }

        public override void Accept(NodeVisitor visitor)
        {
            base.Accept(visitor);
            if (IsNestedType)
            {
                VisitCollection(EnumMembers, visitor.VisitNestedEnumMember);
            }
            else
            {
                VisitCollection(EnumMembers, visitor.VisitEnumMember);
            }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public EnumDeclarationSyntax WithAttributeLists(
            EnumDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public EnumDeclarationSyntax WithModifiers(EnumDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }

        public EnumDeclarationSyntax WithMembers(EnumDeclarationSyntax type, SyntaxList<MemberDeclarationSyntax> members)
        {
            return type;
        }

        public EnumDeclarationSyntax WithBaseList(EnumDeclarationSyntax type, BaseListSyntax baseList)
        {
            return type.WithBaseList(baseList);
        }

        public EnumDeclarationSyntax WithConstraintClauses(
            EnumDeclarationSyntax type,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses)
        {
            return type;
        }
    }
}
