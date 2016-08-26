using System;

namespace CSharpDom.CodeAnalysis
{
    internal class Node<TValue, TSyntax>
        where TSyntax : class
    {
        private Func<TSyntax> getSyntax;
        private Action<TSyntax> setSyntax;
        private object parent;
        private TSyntax syntax;

        public Node(TValue value)
        {
            Value = value;
        }

        public TValue Value { get; private set; }

        public TSyntax Syntax
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
                        setSyntax(syntax);
                    }
                }
            }
        }

        public TParentNode GetParentNode<TParentNode>()
            where TParentNode : class
        {
            if (parent != null && getSyntax() == null)
            {
                parent = null;
            }

            return parent as TParentNode;
        }

        public void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TSyntax> getChildSyntax,
            Func<TParentSyntax, TSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            if (parent == null)
            {
                RefreshSyntax();
                this.getSyntax = null;
                setSyntax = null;
            }

            this.parent = parent;
            if (parent != null)
            {
                getSyntax = () => getChildSyntax(parent.Syntax);
                setSyntax = syntax => parent.Syntax = createChildSyntax(parent.Syntax, syntax);
                setSyntax(syntax);
            }
        }

        public void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<TValue, TSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode(
                parent,
                syntax => getCollection(parent).GetChild(Value),
                CreateChildSyntax<TParentNode, TParentSyntax>(parent, getCollection));
        }
        
        private Func<TParentSyntax, TSyntax, TParentSyntax> CreateChildSyntax<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<TValue, TSyntax>> getCollection)
            where TParentNode : IHasSyntax<TParentSyntax>
        {
            return (parentSyntax, childSyntax) =>
            {
                getCollection(parent).SetChild(Value, childSyntax);
                return parent.Syntax;
            };
        }

        private void RefreshSyntax()
        {
            if (parent != null)
            {
                syntax = getSyntax();
            }
        }
    }
}
