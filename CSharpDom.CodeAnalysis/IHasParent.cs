using System;

namespace CSharpDom.CodeAnalysis
{
    internal interface IHasParent<TChildNode, TChildSyntax>
    {
        void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<TChildNode, TChildSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>;

        void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TChildSyntax> getChildSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>;
    }
}
