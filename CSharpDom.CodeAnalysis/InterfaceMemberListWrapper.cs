using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class InterfaceMemberListWrapper<TChild, TChildSyntax> :
        MemberListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax, TChild, TChildSyntax>
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public InterfaceMemberListWrapper(
            Node<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> node,
            Func<TChild> factory) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory)
        {
        }
    }
}
