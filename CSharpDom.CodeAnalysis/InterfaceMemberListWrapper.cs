using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class InterfaceMemberListWrapper<TChildNode, TChildSyntax> :
        MemberListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax, TChildNode, TChildSyntax>
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
