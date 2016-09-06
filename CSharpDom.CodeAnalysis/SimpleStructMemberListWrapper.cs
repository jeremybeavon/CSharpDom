using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class SimpleStructMemberListWrapper<TChildNode, TChildSyntax> :
        StructTypeMemberListWrapper<EmptySimpleMember, TChildNode, TChildSyntax>
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
        where TChildSyntax : MemberDeclarationSyntax
    {
        public SimpleStructMemberListWrapper(
            Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax> node,
            Func<StructTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, StructTypeWithCodeAnalysis> setParent,
            Func<TChildSyntax, bool> filter = null)
            : base(node, factory, setParent, filter)
        {
        }
    }
}
