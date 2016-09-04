using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class SimpleClassMemberListWrapper<TChildNode, TChildSyntax> :
        ClassMemberListWrapper<EmptySimpleMember, TChildNode, TChildSyntax>
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
        where TChildSyntax : MemberDeclarationSyntax
    {
        public SimpleClassMemberListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<ClassTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, ClassTypeWithCodeAnalysis> setParent,
            Func<TChildSyntax, bool> filter = null)
            : base(node, factory, setParent, filter)
        {
        }
    }
}
