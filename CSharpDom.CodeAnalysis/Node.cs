using System;

namespace CSharpDom.CodeAnalysis
{
    internal class Node<TChildSyntax>
        where TChildSyntax : class
    {
        private Func<TChildSyntax> getChildSyntax;
        private Action<TChildSyntax> setChildSyntax;
        private object parent;
        private TChildSyntax syntax;
        
        public TChildSyntax Syntax
        {
            get
            {
                RefreshSyntax();
                return syntax;
            }
            set
            {
                if (syntax != value)
                {
                    syntax = value;
                    if (parent != null)
                    {
                        setChildSyntax(syntax);
                    }
                }
            }
        }

        public TParentNode GetParentNode<TParentNode>()
            where TParentNode : class
        {
            if (parent != null && getChildSyntax() == null)
            {
                parent = null;
            }

            return parent as TParentNode;
        }

        public void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TChildSyntax> getChildSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            if (parent == null)
            {
                RefreshSyntax();
                this.getChildSyntax = null;
                setChildSyntax = null;
            }

            this.parent = parent;
            if (parent != null)
            {
                this.getChildSyntax = () => getChildSyntax(parent.Syntax);
                setChildSyntax = syntax => parent.Syntax = createChildSyntax(parent.Syntax, syntax);
                setChildSyntax(syntax);
            }
        }
        
        private void RefreshSyntax()
        {
            if (parent != null)
            {
                syntax = getChildSyntax();
            }
        }
    }
}
