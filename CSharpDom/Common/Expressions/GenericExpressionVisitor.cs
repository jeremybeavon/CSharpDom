using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public static class GenericExpressionVisitor
    {
        public static void VisitArrayIndexExpressionChildren<TExpression>(
            IArrayIndexExpression<TExpression> arrayIndexExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(arrayIndexExpression.Array, visitor);
            VisitCollection(arrayIndexExpression.Indexes, visitor);
        }

        public static void VisitAwaitExpressionChildren<TExpression>(
            IAwaitExpression<TExpression> awaitExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(awaitExpression.Expression, visitor);
        }

        public static void VisitBinaryOperatorExpressionChildren<TExpression>(
            IBinaryOperatorExpression<TExpression> binaryOperatorExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(binaryOperatorExpression.Left, visitor);
            VisitIfNotNull(binaryOperatorExpression.Right, visitor);
        }

        public static void VisitCastExpressionChildren<TTypeReference, TExpression>(
            ICastExpression<TTypeReference, TExpression> castExpression,
            IGenericExpressionVisitor visitor)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            VisitIfNotNull(castExpression.Expression, visitor);
        }

        public static void VisitListInitializerExpressionChildren<TCreateListExpression, TExpression>(
            IListInitializerExpression<TCreateListExpression, TExpression> listInitializerExpression,
            IGenericExpressionVisitor visitor)
            where TCreateListExpression : ICreateListExpression
            where TExpression : IExpression
        {
            VisitIfNotNull(listInitializerExpression.CreateListExpression, visitor);
            foreach (IReadOnlyList<TExpression> initialValues in listInitializerExpression.InitialValues)
            {
                VisitCollection(initialValues, visitor);
            }
        }

        public static void VisitMemberExpressionChildren<TExpression>(
            IMemberExpression<TExpression> memberExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(memberExpression.ObjectExpression, visitor);
        }

        public static void VisitMethodCallExpressionChildren<TExpression>(
            IMethodCallExpression<TExpression> methodCallExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(methodCallExpression.Expression, visitor);
            VisitCollection(methodCallExpression.ParameterExpressions, visitor);
        }

        public static void VisitNewArrayExpressionChildren<TTypeReference, TExpression>(
            INewArrayExpression<TTypeReference, TExpression> newArrayExpression,
            IGenericExpressionVisitor visitor)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            VisitCollection(newArrayExpression.InitialSizeExpressions, visitor);
        }

        public static void VisitNewExpressionChildren<TTypeReference, TExpression>(
            INewExpression<TTypeReference, TExpression> newExpression,
            IGenericExpressionVisitor visitor)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            VisitCollection(newExpression.Parameters, visitor);
        }
        
        public static void VisitObjectInitializerExpressionChildren<TCreateObjectExpression, TExpression, TObjectInitializer>(
            IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> objectInitializerExpression,
            IGenericExpressionVisitor visitor)
            where TCreateObjectExpression : ICreateObjectExpression
            where TExpression : IExpression
            where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>
        {
            VisitIfNotNull(objectInitializerExpression.CreateObjectExpression, visitor);
            foreach (TExpression member in objectInitializerExpression.Members.Values)
            {
                VisitIfNotNull(member, visitor);
            }

            foreach (IReadOnlyList<TExpression> element in objectInitializerExpression.Elements)
            {
                VisitCollection(element, visitor);
            }
        }

        public static void VisitOutExpressionChildren<TExpression>(
            IOutExpression<TExpression> outExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(outExpression.Expression, visitor);
        }

        public static void VisitParenthesisExpressionChildren<TExpression>(
            IParenthesisExpression<TExpression> parenthesisExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(parenthesisExpression.Expression, visitor);
        }

        public static void VisitQueryFromExpressionChildren<TExpression, TQueryExpression>(
            IQueryFromExpression<TExpression, TQueryExpression> queryFromExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
            where TQueryExpression : IQueryExpression
        {
            VisitIfNotNull(queryFromExpression.Expression, visitor);
            VisitCollection(queryFromExpression.QueryExpressions, visitor);
        }

        public static void VisitQueryGroupExpressionChildren<TExpression, TIdentiferExpression>(
            IQueryGroupExpression<TExpression, TIdentiferExpression> queryGroupExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
            where TIdentiferExpression : IIdentifierExpression
        {
            VisitIfNotNull(queryGroupExpression.GroupExpression, visitor);
            VisitIfNotNull(queryGroupExpression.ByExpression, visitor);
            VisitIfNotNull(queryGroupExpression.IntoExpression, visitor);
        }

        public static void VisitQueryJoinExpressionChildren<TExpression>(
            IQueryJoinExpression<TExpression> queryJoinExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(queryJoinExpression.InExpression, visitor);
            VisitIfNotNull(queryJoinExpression.OnExpression, visitor);
            VisitIfNotNull(queryJoinExpression.EqualsExpression, visitor);
        }

        public static void VisitQueryLetExpressionChildren<TBinaryOperatorExpression>(
            IQueryLetExpression<TBinaryOperatorExpression> queryLetExpression,
            IGenericExpressionVisitor visitor)
            where TBinaryOperatorExpression : IBinaryOperatorExpression
        {
            VisitIfNotNull(queryLetExpression.Expression, visitor);
        }

        public static void VisitQueryOrderByExpressionChildren<TExpression>(
            IQueryOrderByExpression<TExpression> queryOrderByExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(queryOrderByExpression.Expression, visitor);
        }

        public static void VisitQuerySelectExpressionChildren<TExpression>(
            IQuerySelectExpression<TExpression> querySelectExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(querySelectExpression.Expression, visitor);
        }

        public static void VisitQueryWhereExpressionChildren<TExpression>(
            IQueryWhereExpression<TExpression> queryWhereExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(queryWhereExpression.Expression, visitor);
        }

        public static void VisitRefExpressionChildren<TExpression>(
            IRefExpression<TExpression> refExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(refExpression, visitor);
        }
        
        public static void VisitTernaryOperatorExpressionChildren<TExpression>(
            ITernaryOperatorExpression<TExpression> ternaryOperatorExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(ternaryOperatorExpression.Left, visitor);
            VisitIfNotNull(ternaryOperatorExpression.Middle, visitor);
            VisitIfNotNull(ternaryOperatorExpression.Right, visitor);
        }
        
        public static void VisitUnaryOperatorExpressionChildren<TExpression>(
            IUnaryOperatorExpression<TExpression> unaryOperatorExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(unaryOperatorExpression.Operand, visitor);
        }

        private static void VisitCollection<T>(IReadOnlyCollection<T> collection, IGenericExpressionVisitor visitor)
            where T : IVisitable<IGenericExpressionVisitor>
        {
            GenericVisitor.VisitCollection(collection, visitor);
        }

        private static void VisitIfNotNull(IVisitable<IGenericExpressionVisitor> visitable, IGenericExpressionVisitor visitor)
        {
            GenericVisitor.VisitIfNotNull(visitable, visitor);
        }
    }
}
