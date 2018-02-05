using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public static class ExpressionFactory
    {
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

        public static MethodCallExpressionWithCodeAnalysis MethodCall(
            IExpressionWithCodeAnalysis expression,
            IEnumerable<IExpressionWithCodeAnalysis> parameters)
        {
            return new MethodCallExpressionWithCodeAnalysis(expression, parameters);
        }

        public static NewExpressionWithCodeAnalysis New(
            ITypeReferenceWithCodeAnalysis type,
            IEnumerable<IExpressionWithCodeAnalysis> parameters)
        {
            return new NewExpressionWithCodeAnalysis(type, parameters);
        }
    }
}
