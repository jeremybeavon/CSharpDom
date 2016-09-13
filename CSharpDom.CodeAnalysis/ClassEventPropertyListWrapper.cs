using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassEventPropertyListWrapper<TChildNode> :
        ClassMemberListWrapper<EventPropertyWithCodeAnalysis, TChildNode, EventDeclarationSyntax>
        where TChildNode : class, IHasNode<EventDeclarationSyntax>
    {
        public ClassEventPropertyListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<EventDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
