using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class SimpleClassMemberListWrapper<TChildNode, TChildSyntax> :
        ClassMemberListWrapper<EmptySimpleMember, TChildNode, TChildSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public SimpleClassMemberListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
