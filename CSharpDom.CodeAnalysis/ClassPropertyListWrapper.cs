using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassPropertyListWrapper<TClass, TChildNode> :
        ClassMemberListWrapper<TClass, TChildNode, PropertyDeclarationSyntax>
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
        where TChildNode : class, IHasNode<PropertyDeclarationSyntax>
    {
        public ClassPropertyListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<PropertyDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
