using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class MethodCallExpressionWithCodeAnalysis :
        EditableMethodCallExpression<IExpressionWithCodeAnalysis, IArgumentWithCodeAnalysis>,
        IHasSyntax<InvocationExpressionSyntax>,
        IHasNode<InvocationExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax> node;
        private readonly CachedExpressionNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax> expression;
        private readonly ArgumentListWrapper<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax> parameterExpressions;

        public MethodCallExpressionWithCodeAnalysis(
            IExpressionWithCodeAnalysis expression,
            params IExpressionWithCodeAnalysis[] parameters)
            : this()
        {
            Syntax = SyntaxFactory.InvocationExpression(expression.Syntax, parameters.ToArgumentList());
        }

        internal MethodCallExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax>(this);
            expression = new CachedExpressionNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
            parameterExpressions = new ArgumentListWrapper<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax>(
                node,
                syntax => syntax.ArgumentList,
                (parentSyntax, childSyntax) => parentSyntax.WithArgumentList(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public override IList<IArgumentWithCodeAnalysis> Parameters
        {
            get { return parameterExpressions; }
            set { parameterExpressions.ReplaceList(value); }
        }

        public InvocationExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (InvocationExpressionSyntax)value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        INode<InvocationExpressionSyntax> IHasNode<InvocationExpressionSyntax>.Node => node;
    }
}
