using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class NamespaceMemberListWrapper<TChild, TChildSyntax> :
        ChildNodeList<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax, TChild, TChildSyntax>
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public NamespaceMemberListWrapper(
            Node<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> node,
            Func<TChild> factory,
            Func<TChildSyntax, bool> filter = null)
            : this(
                  node,
                  syntax => syntax.Members,
                  (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax),
                  factory,
                  filter)
        {
        }

        private NamespaceMemberListWrapper(
            Node<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> node,
            Func<NamespaceDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> getList,
            Func<NamespaceDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>, NamespaceDeclarationSyntax> createList,
            Func<TChild> factory,
            Func<TChildSyntax, bool> filter)
            : base(node, ListFactory.CreateFilteredSyntaxList(node, getList, createList, filter), factory)
        {
        }
    }
}