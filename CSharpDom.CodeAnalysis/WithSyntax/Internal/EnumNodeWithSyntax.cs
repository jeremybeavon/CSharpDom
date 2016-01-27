using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class EnumNodeWithSyntax : EnumNode, IEnumSyntax, INestedEnumSyntax
    {
        public EnumNodeWithSyntax(EnumDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        ITypeSyntax IHasDeclaringType<ITypeSyntax>.DeclaringType
        {
            get { return (ITypeSyntax)DeclaringType; }
        }

        IReadOnlyCollection<INestedEnumMemberSyntax> IHasEnumMembers<INestedEnumMemberSyntax>.EnumMembers
        {
            get { return new ReadOnlyNodeCollection<INestedEnumMemberSyntax, EnumMemberNode>(EnumMembers); }
        }

        IReadOnlyCollection<IEnumMemberSyntax> IHasEnumMembers<IEnumMemberSyntax>.EnumMembers
        {
            get { return new ReadOnlyNodeCollection<IEnumMemberSyntax, EnumMemberNode>(EnumMembers); }
        }

        INamespaceSyntax IHasNamespace<INamespaceSyntax>.Namespace
        {
            get { return (INamespaceSyntax)Namespace; }
        }

        IProjectSyntax IHasProject<IProjectSyntax>.Project
        {
            get { return (IProjectSyntax)Project; }
        }

        ISolutionSyntax IHasSolution<ISolutionSyntax>.Solution
        {
            get { return (ISolutionSyntax)Solution; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return IsNestedType ? (AbstractSyntaxNode)new NestedEnumWithSyntax(this) : new EnumWithSyntax(this);
        }
    }
}
