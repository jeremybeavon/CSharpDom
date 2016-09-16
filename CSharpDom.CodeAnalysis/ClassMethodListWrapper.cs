using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMethodListWrapper<TChildNode> :
        ClassMemberListWrapper<TChildNode, MethodDeclarationSyntax>
        where TChildNode : class, IHasNode<MethodDeclarationSyntax>
    {
        public ClassMethodListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<MethodDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
