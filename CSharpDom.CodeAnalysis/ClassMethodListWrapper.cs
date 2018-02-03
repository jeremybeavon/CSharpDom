using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMethodListWrapper<TClass, TChildNode> :
        ClassMemberListWrapper<TClass, TChildNode, MethodDeclarationSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChildNode : class, IHasNode<MethodDeclarationSyntax>
    {
        public ClassMethodListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<MethodDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
