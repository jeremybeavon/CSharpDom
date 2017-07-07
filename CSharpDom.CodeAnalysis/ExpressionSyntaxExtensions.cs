using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.CodeAnalysis.Expressions;

namespace CSharpDom.CodeAnalysis
{
    internal static class ExpressionSyntaxExtensions
    {
        private static readonly IDictionary<Type, Func<IInternalExpression>> expressionMap =
            new Dictionary<Type, Func<IInternalExpression>>()
            {
                //{ typeof(AliasQualifiedNameSyntax), () => },
                //{ typeof(AnonymousMethodExpressionSyntax), () => },
                //{ typeof(AnonymousObjectCreationExpressionSyntax), () => },
                //{ typeof(ArrayCreationExpressionSyntax), () => new newarr },
                //{ typeof(ArrayTypeSyntax), () => },
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
                //{ typeof(ImplicitArrayCreationExpressionSyntax), () => },
                //{ typeof(ImplicitElementAccessSyntax), () => },
                //{ typeof(InitializerExpressionSyntax), () => },
                //{ typeof(InterpolatedStringExpressionSyntax), () => },
                //{ typeof(InvocationExpressionSyntax), () => },
                //{ typeof(MakeRefExpressionSyntax), () => },
                { typeof(MemberAccessExpressionSyntax), () => new MemberExpressionWithCodeAnalysis() },
                //{ typeof(MemberBindingExpressionSyntax), () =>  },
                //{ typeof(NullableTypeSyntax), () => },
                { typeof(ObjectCreationExpressionSyntax), () => new NewExpressionWithCodeAnalysis() },
                //{ typeof(OmittedArraySizeExpressionSyntax), () => },
                //{ typeof(OmittedTypeArgumentSyntax), () => },
                //{ typeof(QualifiedNameSyntax), () => },
                //{ typeof(ParenthesizedLambdaExpressionSyntax), () => },
                //{ typeof(PointerTypeSyntax), () => },
                { typeof(PostfixUnaryExpressionSyntax), () => new UnaryOperatorExpressionWithCodeAnalysis() },
                //{ typeof(PredefinedTypeSyntax), () => new  },
                { typeof(PrefixUnaryExpressionSyntax), () => new UnaryOperatorExpressionWithCodeAnalysis() },
                { typeof(QueryExpressionSyntax), () => new QueryFromExpressionWithCodeAnalysis() },
                //{ typeof(RefTypeExpressionSyntax), () => },
                //{ typeof(RefValueExpressionSyntax), () => },
                //{ typeof(StackAllocArrayCreationExpressionSyntax), () => },
                //{ typeof(SimpleLambdaExpressionSyntax), () => },
                //{ typeof(SimpleNameSyntax), () => },
                //{ typeof(SizeOfExpressionSyntax), () => },
                //{ typeof(ThisExpressionSyntax), () => },
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
            return expressionMap[syntax.GetType()]();
        }
    }
}
