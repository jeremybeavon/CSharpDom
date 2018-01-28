using System;

namespace CSharpDom.CodeAnalysis
{
    internal class Node<TValue, TSyntax> : INode<TSyntax>
        where TSyntax : class
    {
        private readonly Guid internalId;
        private Func<TSyntax> getSyntax;
        private Action<TSyntax> setSyntax;
        private object parent;
        private TSyntax syntax;

        public Node(TValue value)
        {
            internalId = Guid.NewGuid();
            Value = value;
        }

        public Node(TValue value, TSyntax syntax)
            : this(value)
        {
            this.syntax = syntax;
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
                if (!CodeAnalysisSettings.AreEditsAllowed)
                {
                    throw new InvalidOperationException("Edits are not allowed.");
                }

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

        public bool IsLocked { get; set; }

        public Guid InternalId
        {
            get { return internalId; }
        }

        public TParentNode GetParentNode<TParentNode>()
            where TParentNode : class
        {
            if (parent != null && Syntax == null)
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
                getSyntax = null;
                setSyntax = null;
            }

            this.parent = parent;
            if (parent != null)
            {
                getSyntax = () => getChildSyntax(parent.Syntax);
                setSyntax = syntax => parent.Syntax = createChildSyntax(parent.Syntax, syntax);
                if (syntax != null)
                {
                    IsLocked = true;
                    setSyntax(syntax);
                    IsLocked = false;
                }
            }
        }
        
        public void SetParentNode<TParentNode, TParentSyntax, TChildNode>(
            TParentNode parent,
            TChildNode child,
            IChildCollection<TParentSyntax, TChildNode, TSyntax> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode(
                parent,
                syntax => getCollection.GetChild(child),
                CreateChildSyntax<TParentNode, TParentSyntax, TChildNode>(parent, child, getCollection));
        }

        public void RemoveParentNode()
        {
            RefreshSyntax();
            parent = null;
            getSyntax = null;
            setSyntax = null;
        }
        
        private Func<TParentSyntax, TSyntax, TParentSyntax> CreateChildSyntax<TParentNode, TParentSyntax, TChildNode>(
            TParentNode parent,
            TChildNode child,
            IChildCollection<TParentSyntax, TChildNode, TSyntax> collection)
            where TParentNode : IHasSyntax<TParentSyntax>
        {
            return (parentSyntax, childSyntax) => collection.SetChild(child, childSyntax);
        }

        private void RefreshSyntax()
        {
            if (parent != null && ((CodeAnalysisSettings.AreEditsAllowed && !IsLocked) || syntax == null))
            {
                TSyntax newSyntax = getSyntax();
                if (syntax != null && syntax != newSyntax)
                {
                    syntax = newSyntax;
                }
                else
                {
                    syntax = newSyntax;
                }
            }
        }
    }
}
