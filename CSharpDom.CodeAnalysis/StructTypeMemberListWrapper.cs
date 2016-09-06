using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StructTypeMemberListWrapper<TSimpleChildNode, TChildNode, TChildSyntax> :
        MemberListWrapper<StructTypeWithCodeAnalysis, StructDeclarationSyntax, TSimpleChildNode, TChildNode, TChildSyntax>
        where TSimpleChildNode : ISimpleMember
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
        where TChildSyntax : MemberDeclarationSyntax
    {
        public StructTypeMemberListWrapper(
            Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax> node,
            Func<StructTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, StructTypeWithCodeAnalysis> setParent,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, setParent, filter)
        {
        }
    }
}
