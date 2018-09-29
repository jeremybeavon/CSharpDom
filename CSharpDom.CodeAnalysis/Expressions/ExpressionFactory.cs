using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public static class ExpressionFactory
    {
        public static BinaryOperatorExpressionWithCodeAnalysis Binary(
            IExpressionWithCodeAnalysis left,
            BinaryOperatorExpressionType @operator,
            IExpressionWithCodeAnalysis right)
        {
            return new BinaryOperatorExpressionWithCodeAnalysis(left, @operator, right);
        }

        public static CastExpressionWithCodeAnalysis Cast(
            ITypeReferenceWithCodeAnalysis type,
            IExpressionWithCodeAnalysis expression)
        {
            return new CastExpressionWithCodeAnalysis(type, expression);
        }

        public static IdentifierExpressionWithCodeAnalysis Identifier(string name)
        {
            return new IdentifierExpressionWithCodeAnalysis(name);
        }

        public static MemberExpressionWithCodeAnalysis Member(
            IExpressionWithCodeAnalysis objectExpression,
            string memberName)
        {
            return new MemberExpressionWithCodeAnalysis(objectExpression, memberName);
        }

        public static MethodCallExpressionWithCodeAnalysis MethodCall(
            IExpressionWithCodeAnalysis objectExpression,
            string methodName,
            IEnumerable<ITypeReferenceWithCodeAnalysis> genericParameters,
            params IExpressionWithCodeAnalysis[] parameters)
        {
            return new MethodCallExpressionWithCodeAnalysis(objectExpression, methodName, genericParameters, parameters);
        }

        public static MethodCallExpressionWithCodeAnalysis MethodCall(
            IExpressionWithCodeAnalysis expression,
            params IExpressionWithCodeAnalysis[] parameters)
        {
            return new MethodCallExpressionWithCodeAnalysis(expression, parameters);
        }

        public static MethodCallExpressionWithCodeAnalysis MethodCall(
            string methodName,
            params IExpressionWithCodeAnalysis[] parameters)
        {
            return new MethodCallExpressionWithCodeAnalysis(methodName, parameters);
        }

        public static NewExpressionWithCodeAnalysis New(
            ITypeReferenceWithCodeAnalysis type,
            IEnumerable<IExpressionWithCodeAnalysis> parameters)
        {
            return new NewExpressionWithCodeAnalysis(type, parameters);
        }
    }
}
