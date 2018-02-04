using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharpDom.CodeAnalysis
{
    internal class Node<TValue, TSyntax> : INode<TSyntax>
        where TSyntax : class
    {
        private Func<TSyntax> getSyntax;
        private Action<TSyntax> setSyntax;
        private object parent;
        private INode parentNode;
        private TSyntax syntax;

        public Node(TValue value)
        {
            Value = value;
        }

        public Node(TValue value, TSyntax syntax)
            : this(value)
        {
            this.syntax = syntax;
        }

        public TValue Value { get; private set; }

        public int Index { get; set; }

        public IList<INode> ChildNodes { get; } = new List<INode>();

        [DebuggerDisplay("Syntax: {syntax}")]
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
                    if (!CodeAnalysisSettings.AreEditsAllowed)
                    {
                        throw new InvalidOperationException("Edits are not allowed.");
                    }

                    syntax = value;
                    if (parent != null)
                    {
                        setSyntax(syntax);
                    }
                }
            }
        }

        public bool IsLocked { get; set; }
        
        public TParent GetParent<TParent>()
            where TParent : class
        {
            if (parent != null && Syntax == null)
            {
                parent = null;
            }

            return parent as TParent;
        }

        public void SetParent<TParent, TParentSyntax>(
            TParent parent,
            Func<TParentSyntax, TSyntax> getChildSyntax,
            Func<TParentSyntax, TSyntax, TParentSyntax> createChildSyntax)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
        {
            SetParent<TParent, TParentSyntax>(
                parent,
                () => getChildSyntax(parent.Node.Syntax),
                syntax => parent.Node.Syntax = createChildSyntax(parent.Node.Syntax, syntax));
            if (parentNode != null)
            {
                parentNode.ChildNodes.Add(this);
            }
        }

        public void SetParent<TParent, TParentSyntax>(
            TParent parent,
            int childIndex,
            Func<int, TSyntax> getChildSyntax,
            Func<int, TSyntax, TParentSyntax> createChildSyntax)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
        {
            Index = childIndex;
            SetParent<TParent, TParentSyntax>(
                parent,
                () => getChildSyntax(Index),
                syntax => parent.Node.Syntax = createChildSyntax(Index, syntax));
        }

        public void RemoveParentNode()
        {
            RefreshSyntax();
            if (parentNode != null)
            {
                parentNode.ChildNodes.Remove(this);
            }

            parent = null;
            parentNode = null;
            getSyntax = null;
            setSyntax = null;
        }

        public void RefreshSyntax()
        {
            if (parent != null && ((CodeAnalysisSettings.AreEditsAllowed && !IsLocked) || syntax == null))
            {
                syntax = getSyntax();
            }
        }

        private void SetParent<TParent, TParentSyntax>(
            TParent parent,
            Func<TSyntax> getChildSyntax,
            Action<TSyntax> setChildSyntax)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
        {
            if (parent == null)
            {
                RemoveParentNode();
                return;
            }

            this.parent = parent;
            if (parent != null)
            {
                parentNode = parent.Node;
                getSyntax = getChildSyntax;
                setSyntax = setChildSyntax;
                if (syntax != null)
                {
                    IsLocked = true;
                    setSyntax(syntax);
                    IsLocked = false;
                }
            }
        }
    }
}
