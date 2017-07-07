using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryOrderingExpressionWithCodeAnalysis :
        EditableQueryOrderingExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<OrderingSyntax>,
        IHasNode<OrderingSyntax>
    {
        private readonly Node<QueryOrderingExpressionWithCodeAnalysis, OrderingSyntax> node;
        private readonly CachedExpressionNode<QueryOrderingExpressionWithCodeAnalysis, OrderingSyntax> expression;

        internal QueryOrderingExpressionWithCodeAnalysis()
        {
            node = new Node<QueryOrderingExpressionWithCodeAnalysis, OrderingSyntax>(this);
            expression = new CachedExpressionNode<QueryOrderingExpressionWithCodeAnalysis, OrderingSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public override QueryOrderByType OrderByType
        {
            get
            {
                switch (Syntax.AscendingOrDescendingKeyword.Kind())
                {
                    case SyntaxKind.AscendingKeyword:
                        return QueryOrderByType.Ascending;
                    case SyntaxKind.DescendingKeyword:
                        return QueryOrderByType.Descending;
                    default:
                        return QueryOrderByType.None;
                }
            }
            set
            {
                switch (value)
                {
                    case QueryOrderByType.None:
                        Syntax = Syntax.WithAscendingOrDescendingKeyword(SyntaxFactory.Token(SyntaxKind.None));
                        break;
                    case QueryOrderByType.Ascending:
                        Syntax = Syntax.WithAscendingOrDescendingKeyword(SyntaxFactory.Token(SyntaxKind.AscendingKeyword));
                        break;
                    case QueryOrderByType.Descending:
                        Syntax = Syntax.WithAscendingOrDescendingKeyword(SyntaxFactory.Token(SyntaxKind.DescendingKeyword));
                        break;
                }
            }
        }

        public OrderingSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        INode<OrderingSyntax> IHasNode<OrderingSyntax>.Node => node;
    }
}
