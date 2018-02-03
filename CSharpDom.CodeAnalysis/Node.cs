using System;
using System.Diagnostics;

namespace CSharpDom.CodeAnalysis
{
    internal class Node<TValue, TSyntax> : INode<TSyntax>
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

        public Node(TValue value, TSyntax syntax)
            : this(value)
        {
            this.syntax = syntax;
        }

        public TValue Value { get; private set; }

        public int Index { get; set; }

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
            where TParentNode : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
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
                getSyntax = () => getChildSyntax(parent.Node.Syntax);
                setSyntax = syntax => parent.Node.Syntax = createChildSyntax(parent.Node.Syntax, syntax);
                if (syntax != null)
                {
                    IsLocked = true;
                    setSyntax(syntax);
                    IsLocked = false;
                }
            }
        }

        public void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            int childIndex,
            Func<TParentSyntax, int, TSyntax> getChildSyntax,
            Func<TParentSyntax, int, TSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
        {
            Index = childIndex;
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                syntax => getChildSyntax(syntax, Index),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, Index, childSyntax));
        }

        public void RemoveParentNode()
        {
            RefreshSyntax();
            parent = null;
            getSyntax = null;
            setSyntax = null;
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
