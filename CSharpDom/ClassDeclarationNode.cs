using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class ClassDeclarationNode : MemberContainer<ClassDeclarationSyntax>,
        ITypeModifier<ClassDeclarationSyntax>
    {
        protected ClassDeclarationNode(ClassDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public DestructorNode Destructor { get; set; }

        public ClassNode ClassNode { get; set; }

        public ITypeContainer DeclaringType
        {
            get { return Container; }
        }

        public sealed override ICompositeType CompositeType
        {
            get { return ClassNode; }
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
            get { return ClassNode.Namespace; }
        }

        public override void Accept(NodeVisitor visitor)
        {
            base.Accept(visitor);
            if (Destructor != null)
            {
                if (IsNestedType)
                {
                    visitor.VisitNestedDestructor(Destructor);
                }
                else
                {
                    visitor.VisitDestructor(Destructor);
                }
            }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public ClassDeclarationSyntax WithMembers(ClassDeclarationSyntax type, SyntaxList<MemberDeclarationSyntax> members)
        {
            return type.WithMembers(members);
        }

        public ClassDeclarationSyntax WithAttributeLists(
            ClassDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public ClassDeclarationSyntax WithModifiers(ClassDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }

        public ClassDeclarationSyntax WithBaseList(ClassDeclarationSyntax type, BaseListSyntax baseList)
        {
            return type.WithBaseList(baseList);
        }

        public ClassDeclarationSyntax WithConstraintClauses(
            ClassDeclarationSyntax type,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses)
        {
            return type.WithConstraintClauses(constraintClauses);
        }
    }
}
