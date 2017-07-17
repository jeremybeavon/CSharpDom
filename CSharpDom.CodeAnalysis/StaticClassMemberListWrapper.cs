using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StaticClassMemberListWrapper<TChildNode, TChildSyntax> :
        MemberListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax, TChildNode, TChildSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public StaticClassMemberListWrapper(
            Node<StaticClassWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, filter)
        {
        }
    }
}
