using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StaticTypeMemberListWrapper<TStaticClass, TChildNode, TChildSyntax> :
        MemberListWrapper<TStaticClass, ClassDeclarationSyntax, TChildNode, TChildSyntax>
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public StaticTypeMemberListWrapper(
            Node<TStaticClass, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, filter)
        {
        }
    }
}
