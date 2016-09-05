using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class SimpleStaticTypeMemberListWrapper<TChildNode, TChildSyntax> :
        StaticTypeMemberListWrapper<EmptySimpleMember, TChildNode, TChildSyntax>
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
        where TChildSyntax : MemberDeclarationSyntax
    {
        public SimpleStaticTypeMemberListWrapper(
            Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<StaticTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, StaticTypeWithCodeAnalysis> setParent,
            Func<TChildSyntax, bool> filter = null)
            : base(node, factory, setParent, filter)
        {
        }
    }
}
