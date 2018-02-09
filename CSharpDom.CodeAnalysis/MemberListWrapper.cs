using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class MemberListWrapper<TParent, TParentSyntax, TChild, TChildSyntax> :
        ChildNodeList<TParent, TParentSyntax, TChild, TChildSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : TypeDeclarationSyntax
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public MemberListWrapper(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<MemberDeclarationSyntax>, TParentSyntax> createList,
            Func<TChild> factory,
            Func<TChildSyntax, bool> filter = null)
            : base(node, ListFactory.CreateFilteredSyntaxList(node, syntax => syntax.Members, createList, filter), factory)
        {
        }
    }
}