using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class SimpleStructMemberListWrapper<TChildNode, TChildSyntax> :
        StructTypeMemberListWrapper<EmptySimpleMember, TChildNode, TChildSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public SimpleStructMemberListWrapper(
            Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
