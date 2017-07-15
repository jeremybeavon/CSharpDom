using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassEventListWrapper<TClass, TChildNode> :
        ClassMemberListWrapper<TClass, TChildNode, EventFieldDeclarationSyntax>
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
        where TChildNode : class, IHasNode<EventFieldDeclarationSyntax>
    {
        public ClassEventListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<EventFieldDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
