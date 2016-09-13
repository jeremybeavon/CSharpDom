using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StructTypeMemberListWrapper<TSimpleChildNode, TChildNode, TChildSyntax> :
        MemberListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax, TSimpleChildNode, TChildNode, TChildSyntax>
        where TSimpleChildNode : ISimpleMember
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public StructTypeMemberListWrapper(
            Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, filter)
        {
        }
    }
}
