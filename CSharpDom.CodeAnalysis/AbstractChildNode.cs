using System;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class AbstractChildNode<TValue, TSyntax, TChildSyntax> :
        Node<TValue, TChildSyntax>,
        INode<TSyntax>
        where TSyntax : class
        where TChildSyntax : class, TSyntax
    {
        protected AbstractChildNode(TValue value)
            : base(value)
        {
        }

        TSyntax IHasSyntax<TSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (TChildSyntax)value; }
        }

        void INode<TSyntax>.SetParent<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TSyntax> getChildSyntax,
            Func<TParentSyntax, TSyntax, TParentSyntax> createChildSyntax)
        {
            SetParent<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TChildSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        void INode<TSyntax>.SetParent<TParentNode, TParentSyntax>(
            TParentNode parent,
            int childIndex,
            Func<int, TSyntax> getChildSyntax,
            Func<int, TSyntax, TParentSyntax> createChildSyntax)
        {
            SetParent<TParentNode, TParentSyntax>(
                parent,
                childIndex,
                index => (TChildSyntax)getChildSyntax(index),
                (index, syntax) => createChildSyntax(index, syntax));
        }
    }
}
