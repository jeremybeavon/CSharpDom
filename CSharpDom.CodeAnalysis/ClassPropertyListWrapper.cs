using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassPropertyListWrapper<TChildNode> :
        ClassMemberListWrapper<PropertyWithCodeAnalysis, TChildNode, PropertyDeclarationSyntax>
        where TChildNode : class, IHasNode<PropertyDeclarationSyntax>
    {
        public ClassPropertyListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<PropertyDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
