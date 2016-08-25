using System;

namespace CSharpDom.CodeAnalysis
{
    internal class SimpleChildNode<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        SimpleNode<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TChildSyntax : class
    {
        public SimpleChildNode(
            TParentNode parent,
            TChildNode child,
            Func<IChildCollection<TChildNode, TChildSyntax>> getCollection)
            : base(
                  child,
                  parent,
                  ChildNodeFactory.GetChildSyntax<TParentSyntax, TChildNode, TChildSyntax>(child, getCollection),
                  ChildNodeFactory.CreateChildSyntax<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(parent, child, getCollection))
        {
        }
    }
}
