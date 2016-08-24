using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class ChildNode<TChildNode, TChildSyntax> : Node<TChildNode, TChildSyntax>
        where TChildSyntax : class
    {
        public ChildNode(TChildNode child)
            : base(child)
        {
        }

        public void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<IChildCollection<TChildNode, TChildSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode(
                parent,
                ChildNodeFactory.GetChildSyntax<TParentSyntax, TChildNode, TChildSyntax>(Value, getCollection),
                ChildNodeFactory.CreateChildSyntax<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(parent, Value, getCollection));
        }
    }
}
