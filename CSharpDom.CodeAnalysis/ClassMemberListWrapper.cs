using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMemberListWrapper<TClass, TChildNode, TChildSyntax> :
        MemberListWrapper<TClass, ClassDeclarationSyntax, TChildNode, TChildSyntax>
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public ClassMemberListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, filter)
        {
        }
    }
}
