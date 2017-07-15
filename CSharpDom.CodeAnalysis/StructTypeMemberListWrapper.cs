using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StructTypeMemberListWrapper<TStruct, TChildNode, TChildSyntax> :
        MemberListWrapper<TStruct, StructDeclarationSyntax, TChildNode, TChildSyntax>
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public StructTypeMemberListWrapper(
            Node<TStruct, StructDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, filter)
        {
        }
    }
}
