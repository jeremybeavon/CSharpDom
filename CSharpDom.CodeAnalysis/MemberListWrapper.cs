using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class MemberListWrapper<TParentNode, TParentSyntax, TSimpleChildNode, TChildNode, TChildSyntax> :
        ImmutableListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>,
        IChildCollection<TSimpleChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : TypeDeclarationSyntax
        where TSimpleChildNode : ISimpleMember
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

        public TChildSyntax GetChild(TSimpleChildNode child)
        {
            return GetChild(child.Member<TChildNode>());
        }

        public void SetChild(TSimpleChildNode child, TChildSyntax syntax)
        {
            SetChild(child.Member<TChildNode>(), syntax);
        }
    }
}