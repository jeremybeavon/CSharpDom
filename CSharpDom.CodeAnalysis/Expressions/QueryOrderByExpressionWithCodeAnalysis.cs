using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryOrderByExpressionWithCodeAnalysis :
        EditableQueryOrderByExpression<QueryOrderingExpressionWithCodeAnalysis>,
        IHasSyntax<OrderByClauseSyntax>,
        IInternalQueryExpression
    {
        private readonly QueryExpressionNode<QueryOrderByExpressionWithCodeAnalysis, OrderByClauseSyntax> node;
        private readonly SeparatedSyntaxListWrapper<
            QueryOrderByExpressionWithCodeAnalysis,
            OrderByClauseSyntax,
            QueryOrderingExpressionWithCodeAnalysis,
            OrderingSyntax> orders;

        internal QueryOrderByExpressionWithCodeAnalysis()
        {
            node = new QueryExpressionNode<QueryOrderByExpressionWithCodeAnalysis, OrderByClauseSyntax>(this);
            orders = new SeparatedSyntaxListWrapper<QueryOrderByExpressionWithCodeAnalysis, OrderByClauseSyntax, QueryOrderingExpressionWithCodeAnalysis, OrderingSyntax>(
                node,
                syntax => syntax.Orderings,
                (parentSyntax, childSyntax) => parentSyntax.WithOrderings(childSyntax),
                () => new QueryOrderingExpressionWithCodeAnalysis());
        }

        public override IList<QueryOrderingExpressionWithCodeAnalysis> Orders
        {
            get { return orders; }
            set { orders.ReplaceList(value); }
        }

        public OrderByClauseSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }
        
        INode<QueryClauseSyntax> IHasNode<QueryClauseSyntax>.Node => node;
    }
}
