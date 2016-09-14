using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class CastExpressionWithCodeAnalysis :
        EditableCastExpression<ITypeReferenceWithCodeAnalysis, IExpressionWithCodeAnalysis>,
        IHasSyntax<CastExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<CastExpressionWithCodeAnalysis, CastExpressionSyntax> node;
        private readonly CachedExpressionNode<CastExpressionWithCodeAnalysis, CastExpressionSyntax> expression;
        private readonly CachedTypeReferenceNode<CastExpressionWithCodeAnalysis, CastExpressionSyntax> type;

        public CastExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<CastExpressionWithCodeAnalysis, CastExpressionSyntax>(this);
            expression = new CachedExpressionNode<CastExpressionWithCodeAnalysis, CastExpressionSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
            type = new CachedTypeReferenceNode<CastExpressionWithCodeAnalysis, CastExpressionSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public CastExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }
        
        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (CastExpressionSyntax)value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }
    }
}
