using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class ExpressionNode<TValue, TSyntax> : Node<TValue, TSyntax>
        where TValue : IInternalExpression
        where TSyntax : ExpressionSyntax
    {
        public ExpressionNode(TValue value)
            : base(value)
        {
        }

        public void SetExpressionParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<IInternalExpression, ExpressionSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode<TParentNode, TParentSyntax>(parent, CreateChildCollection(getCollection));
        }

        public void SetExpressionParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, ExpressionSyntax> getChildSyntax,
            Func<TParentSyntax, ExpressionSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        private Func<TParentNode, IChildCollection<TValue, TSyntax>> CreateChildCollection<TParentNode>(
            Func<TParentNode, IChildCollection<IInternalExpression, ExpressionSyntax>> getCollection)
        {
            return parent => new SimpleChildCollection<TValue, TSyntax>(
                value => (TSyntax)getCollection(parent).GetChild(value),
                (value, syntax) => getCollection(parent).SetChild(value, syntax));
        }
    }
}
