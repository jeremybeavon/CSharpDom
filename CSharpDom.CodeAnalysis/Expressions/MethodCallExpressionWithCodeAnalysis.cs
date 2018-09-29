using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class MethodCallExpressionWithCodeAnalysis :
        EditableMethodCallExpression<IGenericExpressionWithCodeAnalysis, IArgumentWithCodeAnalysis>,
        IHasSyntax<InvocationExpressionSyntax>,
        IHasNode<InvocationExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax> node;
        private readonly CachedChildNode<
            MethodCallExpressionWithCodeAnalysis,
            InvocationExpressionSyntax,
            IInternalGenericExpression,
            ExpressionSyntax> expression;
        private readonly ArgumentListWrapper<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax> parameterExpressions;

        public MethodCallExpressionWithCodeAnalysis(
            IGenericExpressionWithCodeAnalysis expression,
            params IExpressionWithCodeAnalysis[] parameters)
            : this()
        {
            Syntax = SyntaxFactory.InvocationExpression(expression.Syntax, parameters.ToArgumentList());
        }

        public MethodCallExpressionWithCodeAnalysis(
            string methodName,
            params IExpressionWithCodeAnalysis[] parameters)
            : this(new IdentifierExpressionWithCodeAnalysis(methodName), parameters)
        {
        }

        public MethodCallExpressionWithCodeAnalysis(
            IExpressionWithCodeAnalysis expression,
            string methodName,
            params IExpressionWithCodeAnalysis[] parameters)
            : this(new MemberExpressionWithCodeAnalysis(expression, methodName), parameters)
        {
        }

        public MethodCallExpressionWithCodeAnalysis(
            IExpressionWithCodeAnalysis expression,
            string methodName,
            IEnumerable<ITypeReferenceWithCodeAnalysis> genericParameters,
            params IExpressionWithCodeAnalysis[] parameters)
            : this(new GenericMemberExpressionWithCodeAnalysis(expression, methodName, genericParameters), parameters)
        {
        }

        internal MethodCallExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax>(this);
            expression = new CachedChildNode<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax, IInternalGenericExpression, ExpressionSyntax>(
                node,
                ToInternalGenericExpression,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
            parameterExpressions = new ArgumentListWrapper<MethodCallExpressionWithCodeAnalysis, InvocationExpressionSyntax>(
                node,
                syntax => syntax.ArgumentList,
                (parentSyntax, childSyntax) => parentSyntax.WithArgumentList(childSyntax));
        }

        public override IGenericExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = (IInternalGenericExpression)value; }
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
        
        private static IInternalGenericExpression ToInternalGenericExpression(ExpressionSyntax syntax)
        {
            return syntax is MemberAccessExpressionSyntax member && member.Name is GenericNameSyntax ?
                (IInternalGenericExpression)new GenericMemberExpressionWithCodeAnalysis() :
                syntax.ToInternalExpression();
        }
    }
}
