using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMemberListWrapper<TClass, TChild, TChildSyntax> :
        MemberListWrapper<TClass, ClassDeclarationSyntax, TChild, TChildSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public ClassMemberListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChild> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, filter)
        {
        }
    }
}
