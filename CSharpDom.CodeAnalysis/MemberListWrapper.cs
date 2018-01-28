using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class MemberListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        ChildNodeList<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : TypeDeclarationSyntax
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public MemberListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<MemberDeclarationSyntax>, TParentSyntax> createList,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null)
            : base(node, ListFactory.CreateFilteredList(node, syntax => syntax.Members, createList, filter), factory)
        {
        }
    }
}