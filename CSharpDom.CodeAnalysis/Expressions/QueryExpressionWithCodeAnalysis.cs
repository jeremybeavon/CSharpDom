using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryExpressionWithCodeAnalysis :
        EditableQueryExpression<
            QueryFromExpressionWithCodeAnalysis,
            IQueryExpressionWithCodeAnalysis,
            IQueryEndExpressionWithCodeAnalysis>,
        IHasSyntax<QueryExpressionSyntax>,
        IHasNode<QueryExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<QueryExpressionWithCodeAnalysis, QueryExpressionSyntax> node;
        private readonly CachedChildNode<
            QueryExpressionWithCodeAnalysis,
            QueryExpressionSyntax,
            QueryFromExpressionWithCodeAnalysis,
            FromClauseSyntax> startExpression;
        private readonly CachedChildNode<
            QueryExpressionWithCodeAnalysis,
            QueryExpressionSyntax,
            QueryBodyWithCodeAnalysis,
            QueryBodySyntax> body;
        private readonly QueryExpressionList expressions;
        
        internal QueryExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<QueryExpressionWithCodeAnalysis, QueryExpressionSyntax>(this);
            startExpression = new CachedChildNode<QueryExpressionWithCodeAnalysis, QueryExpressionSyntax, QueryFromExpressionWithCodeAnalysis, FromClauseSyntax>(
                node,
                () => new QueryFromExpressionWithCodeAnalysis(),
                syntax => syntax.FromClause,
                (parentSyntax, childSyntax) => parentSyntax.WithFromClause(childSyntax));
            body = new CachedChildNode<QueryExpressionWithCodeAnalysis, QueryExpressionSyntax, QueryBodyWithCodeAnalysis, QueryBodySyntax>(
                node,
                () => new QueryBodyWithCodeAnalysis(),
                syntax => syntax.Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            expressions = new QueryExpressionList(this);
        }

        public override QueryFromExpressionWithCodeAnalysis StartExpression
        {
            get { return startExpression.Value; }
            set { startExpression.Value = value; }
        }

        public override IList<IQueryExpressionWithCodeAnalysis> Expressions
        {
            get { return expressions; }
            set { expressions.ReplaceList(value); }
        }

        public override IQueryEndExpressionWithCodeAnalysis EndExpression
        {
            get { return expressions.EndExpression; }
            set { expressions.EndExpression = value; }
        }

        public QueryExpressionSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }
        
        internal QueryBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax { get => Syntax; set => Syntax = (QueryExpressionSyntax)value; }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => node;

        INode<QueryExpressionSyntax> IHasNode<QueryExpressionSyntax>.Node => node;
    }
}
