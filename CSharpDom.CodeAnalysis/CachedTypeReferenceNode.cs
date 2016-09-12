using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedTypeReferenceNode<TParentNode, TParentSyntax> :
        CachedChildNode<TParentNode, TParentSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>
        where TParentNode : class
        where TParentSyntax : class
    {
        public CachedTypeReferenceNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, TypeSyntax, TParentSyntax> createSyntax,
            Func<TParentNode, TypeSyntax, ITypeReferenceWithCodeAnalysis> getValue,
            Action<ITypeReferenceWithCodeAnalysis, TParentNode> setParent)
            : base(node, createSyntax, getValue, setParent)
        {
        }
    }
}
