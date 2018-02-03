using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StructTypeMemberListWrapper<TStruct, TChild, TChildSyntax> :
        MemberListWrapper<TStruct, StructDeclarationSyntax, TChild, TChildSyntax>
        where TStruct : class, IHasNode<StructDeclarationSyntax>
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public StructTypeMemberListWrapper(
            Node<TStruct, StructDeclarationSyntax> node,
            Func<TChild> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, filter)
        {
        }
    }
}
