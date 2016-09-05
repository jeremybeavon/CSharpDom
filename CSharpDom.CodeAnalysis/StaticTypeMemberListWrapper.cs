using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StaticTypeMemberListWrapper<TSimpleChildNode, TChildNode, TChildSyntax> :
        MemberListWrapper<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax, TSimpleChildNode, TChildNode, TChildSyntax>
        where TSimpleChildNode : ISimpleMember
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
        where TChildSyntax : MemberDeclarationSyntax
    {
        public StaticTypeMemberListWrapper(
            Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<StaticTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, StaticTypeWithCodeAnalysis> setParent,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, setParent, filter)
        {
        }
    }
}
