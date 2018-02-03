﻿using CSharpDom.CodeAnalysis.Statements;
using CSharpDom.BaseClasses.Editable.Expressions;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class AnonymousMethodExpressionWithCodeAnalysis :
        EditableAnonymousMethodExpression<AnonymousMethodParameterWithCodeAnalysis, BlockStatementWithCodeAnalysis>,
        IHasSyntax<AnonymousMethodExpressionSyntax>,
        IHasNode<AnonymousMethodExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax> node;
        private readonly CachedChildNode<
            AnonymousMethodExpressionWithCodeAnalysis,
            AnonymousMethodExpressionSyntax,
            BlockStatementWithCodeAnalysis,
            BlockSyntax> body;
        private SeparatedSyntaxNodeList<
            AnonymousMethodExpressionWithCodeAnalysis,
            AnonymousMethodExpressionSyntax,
            AnonymousMethodParameterWithCodeAnalysis,
            ParameterSyntax> parameters;

        internal AnonymousMethodExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax>(this);
            body = new CachedChildNode<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax, BlockStatementWithCodeAnalysis, BlockSyntax>(
                node,
                () => new BlockStatementWithCodeAnalysis(),
                syntax => syntax.Block,
                (parentSyntax, childSyntax) => parentSyntax.WithBlock(childSyntax));
            parameters = new SeparatedSyntaxNodeList<AnonymousMethodExpressionWithCodeAnalysis, AnonymousMethodExpressionSyntax, AnonymousMethodParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                () => new AnonymousMethodParameterWithCodeAnalysis());
        }

        public override BlockStatementWithCodeAnalysis Body
        {
            get { return body.Value; }
            set { body.Value = value; }
        }

        public override IList<AnonymousMethodParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set { parameters.ReplaceList(value); }
        }

        public AnonymousMethodExpressionSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get => Syntax;
            set => Syntax = (AnonymousMethodExpressionSyntax)value;
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => node;

        INode<AnonymousMethodExpressionSyntax> IHasNode<AnonymousMethodExpressionSyntax>.Node => node;
    }
}
