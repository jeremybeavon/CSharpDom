using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryIntoExpressionWithCodeAnalysis :
        EditableIdentifierExpression,
        IHasSyntax<QueryContinuationSyntax>,
        IHasNode<QueryContinuationSyntax>
    {
        private readonly Node<QueryIntoExpressionWithCodeAnalysis, QueryContinuationSyntax> node;
        private readonly CachedChildNode<
            QueryIntoExpressionWithCodeAnalysis,
            QueryContinuationSyntax,
            QueryBodyWithCodeAnalysis,
            QueryBodySyntax> body;

        internal QueryIntoExpressionWithCodeAnalysis()
        {
            node = new Node<QueryIntoExpressionWithCodeAnalysis, QueryContinuationSyntax>(this);
            body = new CachedChildNode<QueryIntoExpressionWithCodeAnalysis, QueryContinuationSyntax, QueryBodyWithCodeAnalysis, QueryBodySyntax>(
                node,
                () => new QueryBodyWithCodeAnalysis(),
                syntax => syntax.Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
        }

        public override string Name
        {
            get { return node.Syntax.Identifier.Text; }
            set { node.Syntax = node.Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        internal QueryBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
            set { body.Value = value; }
        }

        public QueryContinuationSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        INode<QueryContinuationSyntax> IHasNode<QueryContinuationSyntax>.Node => node;
    }
}
