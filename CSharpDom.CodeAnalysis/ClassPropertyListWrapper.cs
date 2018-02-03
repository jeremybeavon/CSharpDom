using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassPropertyListWrapper<TClass, TChild> :
        ClassMemberListWrapper<TClass, TChild, PropertyDeclarationSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChild : class, IHasNode<PropertyDeclarationSyntax>
    {
        public ClassPropertyListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChild> factory,
            Func<PropertyDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
