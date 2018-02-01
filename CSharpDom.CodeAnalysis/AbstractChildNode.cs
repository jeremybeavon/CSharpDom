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

        void INode<TSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TSyntax> getChildSyntax,
            Func<TParentSyntax, TSyntax, TParentSyntax> createChildSyntax)
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TChildSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        void INode<TSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            int childIndex,
            Func<TParentSyntax, int, TSyntax> getChildSyntax,
            Func<TParentSyntax, int, TSyntax, TParentSyntax> createChildSyntax)
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                childIndex,
                (syntax, index) => (TChildSyntax)getChildSyntax(syntax, index),
                (parentSyntax, index, childSyntax) => createChildSyntax(parentSyntax, index, childSyntax));
        }
    }
}
