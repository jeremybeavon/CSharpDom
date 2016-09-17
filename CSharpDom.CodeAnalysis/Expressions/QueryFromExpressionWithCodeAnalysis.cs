using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryFromExpressionWithCodeAnalysis :
        EditableQueryFromExpression<
            IExpressionWithCodeAnalysis,
            IQueryExpressionWithCodeAnalysis>,
        IHasSyntax<QueryExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax> node;
        private readonly CachedExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax> expression;

        public QueryFromExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax>(this);
            expression = new CachedExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax>(
                node,
                syntax => syntax.FromClause.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithFromClause(parentSyntax.FromClause.WithExpression(childSyntax)));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public override string Identifier
        {
            get { return Syntax.FromClause.Identifier.Text; }
            set
            {
                QueryExpressionSyntax syntax = Syntax;
                Syntax = syntax.WithFromClause(syntax.FromClause.WithIdentifier(SyntaxFactory.Identifier(value)));
            }
        }

        public override IList<IQueryExpressionWithCodeAnalysis> QueryExpressions
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public QueryExpressionSyntax Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
