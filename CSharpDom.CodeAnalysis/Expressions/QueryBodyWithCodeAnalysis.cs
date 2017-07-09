using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal sealed class QueryBodyWithCodeAnalysis : IHasSyntax<QueryBodySyntax>, IHasNode<QueryBodySyntax>
    {
        private readonly Node<QueryBodyWithCodeAnalysis, QueryBodySyntax> node;
        private readonly QueryExpressionListWrapper<QueryBodyWithCodeAnalysis, QueryBodySyntax> expressions;
        private readonly CachedChildNode<
            QueryBodyWithCodeAnalysis,
            QueryBodySyntax,
            IHasNode<SelectOrGroupClauseSyntax>,
            SelectOrGroupClauseSyntax> endExpression;
        private readonly CachedChildNode<
            QueryBodyWithCodeAnalysis,
            QueryBodySyntax,
            QueryIntoExpressionWithCodeAnalysis,
            QueryContinuationSyntax> intoExpression;

        public QueryBodyWithCodeAnalysis()
        {
            node = new Node<QueryBodyWithCodeAnalysis, QueryBodySyntax>(this);
            expressions = new QueryExpressionListWrapper<QueryBodyWithCodeAnalysis, QueryBodySyntax>(
                node,
                syntax => syntax.Clauses,
                (parentSyntax, childSyntax) => parentSyntax.WithClauses(childSyntax));
            endExpression = new CachedChildNode<QueryBodyWithCodeAnalysis, QueryBodySyntax, IHasNode<SelectOrGroupClauseSyntax>, SelectOrGroupClauseSyntax>(
                node,
                ToEndExpression,
                syntax => syntax.SelectOrGroup,
                (parentSyntax, childSyntax) => parentSyntax.WithSelectOrGroup(childSyntax));
            intoExpression = new CachedChildNode<QueryBodyWithCodeAnalysis, QueryBodySyntax, QueryIntoExpressionWithCodeAnalysis, QueryContinuationSyntax>(
                node,
                () => new QueryIntoExpressionWithCodeAnalysis(),
                syntax => syntax.Continuation,
                (parentSyntax, childSyntax) => parentSyntax.WithContinuation(childSyntax));
        }

        public IList<IQueryExpressionWithCodeAnalysis> Expressions
        {
            get { return expressions; }
            set { expressions.ReplaceList(value); }
        }

        public IEnumerable<IQueryExpressionWithCodeAnalysis> AllExpressions
        {
            get
            {
                IEnumerable<IQueryExpressionWithCodeAnalysis> enumerable = Expressions;
                IQueryExpressionWithCodeAnalysis endExpression = ContinuationExpression;
                if (endExpression != null)
                {
                    enumerable = enumerable.Concat(new IQueryExpressionWithCodeAnalysis[] { endExpression });
                }

                return enumerable;
            }
        }

        public IQueryExpressionWithCodeAnalysis ContinuationExpression
        {
            get { return endExpression.Value as IQueryExpressionWithCodeAnalysis; }
            set { endExpression.Value = value as IHasNode<SelectOrGroupClauseSyntax>; }
        }

        public IQueryEndExpressionWithCodeAnalysis EndExpression
        {
            get { return endExpression.Value as IQueryEndExpressionWithCodeAnalysis; }
            set { endExpression.Value = value as IHasNode<SelectOrGroupClauseSyntax>; }
        }

        public QueryIntoExpressionWithCodeAnalysis IntoExpression
        {
            get { return intoExpression.Value; }
            set { intoExpression.Value = value; }
        }

        public QueryBodySyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        public INode<QueryBodySyntax> Node => node;

        private IHasNode<SelectOrGroupClauseSyntax> ToEndExpression(SelectOrGroupClauseSyntax syntax)
        {
            bool hasInto = Syntax.Continuation != null;
            if (syntax is SelectClauseSyntax)
            {
                return hasInto ?
                    (IHasNode<SelectOrGroupClauseSyntax>)new QuerySelectIntoExpressionWithCodeAnalysis() :
                    new QuerySelectExpressionWithCodeAnalysis();
            }

            return hasInto ?
                (IHasNode<SelectOrGroupClauseSyntax>)new QueryGroupIntoExpressionWithCodeAnalysis() :
                new QueryGroupExpressionWithCodeAnalysis();
        }
    }
}
