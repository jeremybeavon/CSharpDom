using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class ExpressionNode<TValue, TSyntax> : Node<TValue, TSyntax>, INode<ExpressionSyntax>
        where TValue : IInternalExpression
        where TSyntax : ExpressionSyntax
    {
        public ExpressionNode(TValue value)
            : base(value)
        {
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (TSyntax)value; }
        }
        
        private Func<TParentNode, IChildCollection<TValue, TSyntax>> CreateChildCollection<TParentNode>(
            Func<TParentNode, IChildCollection<IInternalExpression, ExpressionSyntax>> getCollection)
        {
            return parent => new SimpleChildCollection<TValue, TSyntax>(
                value => (TSyntax)getCollection(parent).GetChild(value),
                (value, syntax) => getCollection(parent).SetChild(value, syntax));
        }

        void INode<ExpressionSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, ExpressionSyntax> getChildSyntax,
            Func<TParentSyntax, ExpressionSyntax, TParentSyntax> createChildSyntax)
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        void INode<ExpressionSyntax>.SetParentNode<TParentNode, TParentSyntax, TChildNode>(
            TParentNode parent,
            TChildNode child,
            IChildCollection<TChildNode, ExpressionSyntax> getCollection)
        {
            //SetParentNode<TParentNode, TParentSyntax, TChildNode>()
        }
    }
}
