using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StructMethodListWrapper<TChildNode> :
        StructTypeMemberListWrapper<TChildNode, MethodDeclarationSyntax>
        where TChildNode : class, IHasNode<MethodDeclarationSyntax>
    {
        public StructMethodListWrapper(
            Node<StructTypeWithCodeAnalysis, StructDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<MethodDeclarationSyntax, bool> filter = null) :
            base(node, factory, filter)
        {
        }
    }
}
