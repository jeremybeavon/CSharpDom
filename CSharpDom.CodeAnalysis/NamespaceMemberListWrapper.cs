using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class NamespaceMemberListWrapper<TChildNode, TChildSyntax> :
        ChildNodeList<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax, TChildNode, TChildSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public NamespaceMemberListWrapper(
            Node<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> node,
            Func<TChildNode> factory,
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
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter)
            : base(node, ListFactory.CreateFilteredList(node, getList, createList, filter), factory)
        {
        }
    }
}