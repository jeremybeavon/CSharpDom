using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class SimpleNode<TParentNode, TParentSyntax, TChildNode, TChildSyntax> : Node<TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TChildSyntax : class
    {
        private readonly Func<TParentSyntax, TChildSyntax> getChildSyntax;
        private readonly Func<TParentSyntax, TChildSyntax, TParentSyntax> createChildSyntax;
        private readonly Func<TParentNode, IChildCollection<TChildNode, TChildSyntax>> getCollection;

        public SimpleNode(
            TChildNode child,
            TParentNode parent,
            Func<TParentSyntax, TChildSyntax> getChildSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createChildSyntax)
            : base(child)
        {
            this.getChildSyntax = getChildSyntax;
            this.createChildSyntax = createChildSyntax;
            Parent = parent;
        }

        public SimpleNode(
            TParentNode parent,
            TChildNode child,
            Func<TParentNode, IChildCollection<TChildNode, TChildSyntax>> getCollection)
            : base(child)
        {
            this.getCollection = getCollection;
            Parent = parent;
        }

        public TParentNode Parent
        {
            get { return GetParentNode<TParentNode>(); }
            set
            {
                if (getCollection != null)
                {
                    SetParentNode<TParentNode, TParentSyntax>(value, getCollection);
                }
                else
                {
                    SetParentNode(value, getChildSyntax, createChildSyntax);
                }
            }
        }
    }
}
