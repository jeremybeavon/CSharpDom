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

        public SimpleNode(
            TChildNode child,
            TParentNode parent,
            Func<TParentSyntax, TChildSyntax> getChildSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createChildSyntax)
            : base(child)
        {
            SetParentNode(parent, getChildSyntax, createChildSyntax);
            this.getChildSyntax = getChildSyntax;
            this.createChildSyntax = createChildSyntax;
        }
        
        public TParentNode Parent
        {
            get { return GetParentNode<TParentNode>(); }
            set { SetParentNode(value, getChildSyntax, createChildSyntax); }
        }
    }
}
