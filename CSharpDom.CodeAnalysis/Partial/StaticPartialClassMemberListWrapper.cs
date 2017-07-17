using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal class StaticPartialClassMemberListWrapper<TChildNode, TChildSyntax> :
        ClassMemberListWrapper<StaticPartialClassWithCodeAnalysis, TChildNode, TChildSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public StaticPartialClassMemberListWrapper(
            Node<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, factory, filter)
        {
        }
    }
}
