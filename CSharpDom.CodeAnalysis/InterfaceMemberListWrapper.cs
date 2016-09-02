using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class InterfaceMemberListWrapper<TSimpleChildNode, TChildNode, TChildSyntax> :
        MemberListWrapper<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax, TSimpleChildNode, TChildNode, TChildSyntax>
        where TSimpleChildNode : ISimpleMember
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
        where TChildSyntax : MemberDeclarationSyntax
    {
        public InterfaceMemberListWrapper(
            Node<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> node,
            Func<InterfaceTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, InterfaceTypeWithCodeAnalysis> setParent) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, setParent)
        {
        }
    }
}
