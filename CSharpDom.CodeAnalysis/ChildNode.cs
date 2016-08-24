using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class ChildNode<TChildNode, TChildSyntax> : Node<TChildSyntax>
        where TChildSyntax : class
    {
        private readonly TChildNode child;

        public ChildNode(TChildNode child)
        {
            this.child = child;
        }

        public void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<IChildCollection<TChildNode, TChildSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode(
                parent,
                ChildNodeFactory.GetChildSyntax<TParentSyntax, TChildNode, TChildSyntax>(child, getCollection),
                ChildNodeFactory.CreateChildSyntax<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(parent, child, getCollection));
        }
    }
}
