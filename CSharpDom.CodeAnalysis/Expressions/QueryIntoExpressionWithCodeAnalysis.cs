﻿using CSharpDom.Editable.Expressions;
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

        internal QueryIntoExpressionWithCodeAnalysis()
        {
            node = new Node<QueryIntoExpressionWithCodeAnalysis, QueryContinuationSyntax>(this);
        }

        public override string Name
        {
            get { return node.Syntax.Identifier.Text; }
            set { node.Syntax = node.Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public QueryContinuationSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        INode<QueryContinuationSyntax> IHasNode<QueryContinuationSyntax>.Node => node;
    }
}