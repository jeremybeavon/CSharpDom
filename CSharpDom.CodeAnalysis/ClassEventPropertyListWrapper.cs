using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassEventPropertyListWrapper<TClass, TChild> :
        ClassMemberListWrapper<TClass, TChild, EventDeclarationSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChild : class, IHasNode<EventDeclarationSyntax>
    {
        public ClassEventPropertyListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChild> factory,
            Func<EventDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
