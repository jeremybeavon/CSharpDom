using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassEventListWrapper<TClass, TChild> :
        ClassMemberListWrapper<TClass, TChild, EventFieldDeclarationSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChild : class, IHasNode<EventFieldDeclarationSyntax>
    {
        public ClassEventListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChild> factory,
            Func<EventFieldDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
