using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class InterfaceMemberListWrapper<TSimpleChildNode, TChildNode, TChildSyntax> :
        MemberListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax, TSimpleChildNode, TChildNode, TChildSyntax>
        where TSimpleChildNode : ISimpleMember
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public InterfaceMemberListWrapper(
            Node<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> node,
            Func<TChildNode> factory) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory)
        {
        }
    }
}
