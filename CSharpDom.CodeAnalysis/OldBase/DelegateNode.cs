using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class DelegateNode : AbstractNode<DelegateDeclarationSyntax, ITypeContainer>,
        ITypeModifier<DelegateDeclarationSyntax>
    {
        protected DelegateNode(DelegateDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public string Name
        {
            get { return Declaration.Identifier.ToString(); }
        }

        public int GenericParameterCount
        {
            get { return Declaration.TypeParameterList.Parameters.Count; }
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

        public bool IsGeneric
        {
            get { return false; }
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

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public DelegateDeclarationSyntax WithAttributeLists(
            DelegateDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public DelegateDeclarationSyntax WithModifiers(DelegateDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }

        public DelegateDeclarationSyntax WithMembers(
            DelegateDeclarationSyntax type,
            SyntaxList<MemberDeclarationSyntax> members)
        {
            return type;
        }

        public DelegateDeclarationSyntax WithBaseList(DelegateDeclarationSyntax type, BaseListSyntax baseList)
        {
            return type;
        }

        public DelegateDeclarationSyntax WithConstraintClauses(
            DelegateDeclarationSyntax type,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses)
        {
            return type.WithConstraintClauses(constraintClauses);
        }
    }
}
