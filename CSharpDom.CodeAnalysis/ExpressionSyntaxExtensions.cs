using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.CodeAnalysis.Expressions;

namespace CSharpDom.CodeAnalysis
{
    internal static class ExpressionSyntaxExtensions
    {
        private static readonly TypedFactory<IInternalExpression> expressionMap =
            new TypedFactory<IInternalExpression>()
            {
                { typeof(AnonymousMethodExpressionSyntax), () => new AnonymousMethodExpressionWithCodeAnalysis() },
                //{ typeof(AnonymousObjectCreationExpressionSyntax), () => },
                //{ typeof(ArrayCreationExpressionSyntax), () => new newarr },
                { typeof(AssignmentExpressionSyntax), () => new BinaryOperatorExpressionWithCodeAnalysis() },
                { typeof(AwaitExpressionSyntax), () => new AwaitExpressionWithCodeAnalysis() },
                //{ typeof(BaseExpressionSyntax), () => },
                { typeof(BinaryExpressionSyntax), () => new BinaryOperatorExpressionWithCodeAnalysis() },
                { typeof(CastExpressionSyntax), () => new CastExpressionWithCodeAnalysis() },
                //{ typeof(CheckedExpressionSyntax), () => },
                //{ typeof(ConditionalAccessExpressionSyntax), () => },
                { typeof(ConditionalExpressionSyntax), () => new TernaryOperatorExpressionWithCodeAnalysis() },
                { typeof(DefaultExpressionSyntax), () => new DefaultExpressionWithCodeAnalysis() },
                //{ typeof(ElementBindingExpressionSyntax), () => },
                { typeof(ElementAccessExpressionSyntax), () => new ArrayIndexExpressionWithCodeAnalysis() },
                //{ typeof(GenericNameSyntax), () => },
                { typeof(IdentifierNameSyntax), () => new IdentifierExpressionWithCodeAnalysis() },
                //{ typeof(ImplicitArrayCreationExpressionSyntax), () => },
                //{ typeof(ImplicitElementAccessSyntax), () => },
                //{ typeof(InitializerExpressionSyntax), () => },
                //{ typeof(InterpolatedStringExpressionSyntax), () => },
                { typeof(InvocationExpressionSyntax), () => new MethodCallExpressionWithCodeAnalysis() },
                //{ typeof(MakeRefExpressionSyntax), () => },
                { typeof(MemberAccessExpressionSyntax), () => new MemberExpressionWithCodeAnalysis() },
                //{ typeof(MemberBindingExpressionSyntax), () =>  },
                { typeof(ObjectCreationExpressionSyntax), () => new NewExpressionWithCodeAnalysis() },
                //{ typeof(OmittedArraySizeExpressionSyntax), () => },
                //{ typeof(OmittedTypeArgumentSyntax), () => },
                { typeof(ParenthesizedExpressionSyntax), () => new ParenthesisExpressionWithCodeAnalysis() },
                //{ typeof(ParenthesizedLambdaExpressionSyntax), () => new ParenthesisExpressionWithCodeAnalysis() },
                { typeof(PostfixUnaryExpressionSyntax), () => new UnaryOperatorExpressionWithCodeAnalysis() },
                { typeof(PrefixUnaryExpressionSyntax), () => new UnaryOperatorExpressionWithCodeAnalysis() },
                { typeof(QueryExpressionSyntax), () => new QueryExpressionWithCodeAnalysis() },
                //{ typeof(RefTypeExpressionSyntax), () => },
                //{ typeof(RefValueExpressionSyntax), () => },
                //{ typeof(StackAllocArrayCreationExpressionSyntax), () => },
                //{ typeof(SimpleLambdaExpressionSyntax), () => },
                //{ typeof(SizeOfExpressionSyntax), () => },
                { typeof(ThisExpressionSyntax), () => new ThisExpressionWithCodeAnalysis(null) },
                { typeof(TypeOfExpressionSyntax), () => new TypeofExpressionWithCodeAnalysis() },
            };
        
        public static IInternalExpression ToInternalExpression(this ExpressionSyntax syntax)
        {
            if (syntax is LiteralExpressionSyntax literalExpression)
            {
                object value = literalExpression.Token.Value;
                if (value == null)
                {
                    return new NullExpressionWithCodeAnalysis();
                }

                /*switch (Type.GetTypeCode(value.GetType()))
                {
                    
                }*/
            }
            return expressionMap.Create(syntax.GetType());
        }
    }
}
