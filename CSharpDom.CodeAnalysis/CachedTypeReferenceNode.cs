using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedTypeReferenceNode<TParent, TParentSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly CachedChildNode<TParent, TParentSyntax, IInternalTypeReferenceWithCodeAnalysis, TypeSyntax> childNode;

        public CachedTypeReferenceNode(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, TypeSyntax> getChildSyntax,
            Func<TParentSyntax, TypeSyntax, TParentSyntax> createChildSyntax,
            Func<TypeSyntax, IInternalTypeReferenceWithCodeAnalysis> createChildNode = null)
        {
            childNode = new CachedChildNode<TParent, TParentSyntax, IInternalTypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                createChildNode ?? TypeSyntaxExtensions.ToTypeReference,
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
