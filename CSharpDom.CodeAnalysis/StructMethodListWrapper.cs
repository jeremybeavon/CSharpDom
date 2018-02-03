using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StructMethodListWrapper<TStruct, TChild> :
        StructTypeMemberListWrapper<TStruct, TChild, MethodDeclarationSyntax>
        where TStruct : class, IHasNode<StructDeclarationSyntax>
        where TChild : class, IHasNode<MethodDeclarationSyntax>
    {
        public StructMethodListWrapper(
            Node<TStruct, StructDeclarationSyntax> node,
            Func<TChild> factory,
            Func<MethodDeclarationSyntax, bool> filter = null) :
            base(node, factory, filter)
        {
        }
    }
}
