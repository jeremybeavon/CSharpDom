using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassEventPropertyListWrapper<TClass, TChildNode> :
        ClassMemberListWrapper<TClass, TChildNode, EventDeclarationSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChildNode : class, IHasNode<EventDeclarationSyntax>
    {
        public ClassEventPropertyListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<EventDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
