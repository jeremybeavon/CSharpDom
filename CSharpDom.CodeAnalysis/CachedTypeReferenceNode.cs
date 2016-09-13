using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedTypeReferenceNode<TParentNode, TParentSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly CachedChildNode<TParentNode, TParentSyntax, IInternalTypeReferenceWithCodeAnalysis, TypeSyntax> childNode;

        public CachedTypeReferenceNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, TypeSyntax> getChildSyntax,
            Func<TParentSyntax, TypeSyntax, TParentSyntax> createChildSyntax)
        {
            childNode = new CachedChildNode<TParentNode, TParentSyntax, IInternalTypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                TypeSyntaxExtensions.ToTypeReference,
                getChildSyntax,
                createChildSyntax);
        }

        public ITypeReferenceWithCodeAnalysis Value
        {
            get { return childNode.Value; }
            set { childNode.Value = (IInternalTypeReferenceWithCodeAnalysis)value; }
        }
    }
}
