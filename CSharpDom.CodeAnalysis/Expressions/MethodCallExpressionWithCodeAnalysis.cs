using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class MethodCallExpressionWithCodeAnalysis :
        EditableMethodCallExpression<IExpressionWithCodeAnalysis, ITypeReferenceWithCodeAnalysis, IArgumentWithCodeAnalysis>,
        IHasSyntax<InvocationExpressionSyntax>,
        IHasNode<InvocationExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax> node;
        private readonly CachedExpressionNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax> expression;
        private readonly GenericParameterList<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax> genericParameters;
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
            genericParameters = new GenericParameterList<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax>(
                node,
                syntax => syntax.Expression as NameSyntax,
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

        public override IList<ITypeReferenceWithCodeAnalysis> GenericParameters
        {
            get => genericParameters;
            set => genericParameters.ReplaceList(value);
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

        private static InvocationExpressionSyntax WithGenericParameters(
            InvocationExpressionSyntax parentSyntax,
            SeparatedSyntaxList<TypeSyntax> childSyntax)
        {
            ExpressionSyntax expression = parentSyntax.Expression;
            if (expression is GenericNameSyntax genericNameSyntax && childSyntax.Count == 0)
            {
                return parentSyntax.WithExpression(SyntaxFactory.IdentifierName(genericNameSyntax.Identifier));
            }

            if (expression is NameSyntax nameSyntax)
            {
                return parentSyntax.WithExpression(nameSyntax.WithGenericParameters(childSyntax));
            }

            throw new NotSupportedException();
        }
    }
}
