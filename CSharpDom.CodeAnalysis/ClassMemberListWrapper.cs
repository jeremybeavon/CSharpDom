using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMemberListWrapper<TSimpleChildNode, TChildNode, TChildSyntax> :
        MemberListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax, TSimpleChildNode, TChildNode, TChildSyntax>
        where TSimpleChildNode : ISimpleMember
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public ClassMemberListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null) :
            base(node, (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax), factory, filter)
        {
        }
    }
}
