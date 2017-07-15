using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StructMethodListWrapper<TStruct, TChildNode> :
        StructTypeMemberListWrapper<TStruct, TChildNode, MethodDeclarationSyntax>
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
        where TChildNode : class, IHasNode<MethodDeclarationSyntax>
    {
        public StructMethodListWrapper(
            Node<TStruct, StructDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<MethodDeclarationSyntax, bool> filter = null) :
            base(node, factory, filter)
        {
        }
    }
}
