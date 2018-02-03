using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMethodListWrapper<TClass, TChild> :
        ClassMemberListWrapper<TClass, TChild, MethodDeclarationSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChild : class, IHasNode<MethodDeclarationSyntax>
    {
        public ClassMethodListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChild> factory,
            Func<MethodDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
