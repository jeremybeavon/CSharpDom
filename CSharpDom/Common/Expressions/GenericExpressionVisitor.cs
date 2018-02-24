using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public static class GenericExpressionVisitor
    {
        public static void VisitArgumentChildren<TExpression>(
            IArgument<TExpression> argument,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(argument.Expression, visitor);
        }

        public static void VisitArrayIndexExpressionChildren<TExpression, TArgument>(
            IArrayIndexExpression<TExpression, TArgument> arrayIndexExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
            where TArgument : IArgument
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

        public static void VisitAnonymousMethodExpressionChildren<TParameter, TStatement>(
            IAnonymousMethodExpression<TParameter, TStatement> anonymousMethodExpression,
            IGenericExpressionVisitor visitor)
            where TParameter : IAnonymousMethodParameter
            where TStatement : IStatement
        {
            VisitCollection(anonymousMethodExpression.Parameters, visitor);
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

        public static void VisitMethodCallExpressionChildren<TExpression, TArgument>(
            IMethodCallExpression<TExpression, TArgument> methodCallExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
            where TArgument : IArgument
        {
            VisitIfNotNull(methodCallExpression.Expression, visitor);
            VisitCollection(methodCallExpression.Parameters, visitor);
        }

        public static void VisitNewArrayExpressionChildren<TTypeReference, TExpression>(
            INewArrayExpression<TTypeReference, TExpression> newArrayExpression,
            IGenericExpressionVisitor visitor)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            VisitCollection(newArrayExpression.InitialSizeExpressions, visitor);
        }

        public static void VisitNewExpressionChildren<TTypeReference, TArgument>(
            INewExpression<TTypeReference, TArgument> newExpression,
            IGenericExpressionVisitor visitor)
            where TTypeReference : ITypeReference
            where TArgument : IArgument
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

        public static void VisitOutArgumentChildren<TExpression>(
            IOutArgument<TExpression> outArgument,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(outArgument.Expression, visitor);
        }

        public static void VisitParenthesisExpressionChildren<TExpression>(
            IParenthesisExpression<TExpression> parenthesisExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(parenthesisExpression.Expression, visitor);
        }

        public static void VisitQueryExpressionChildren<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>(
            IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> queryExpression,
            IGenericExpressionVisitor visitor)
            where TQueryFromExpression : IQueryFromExpression
            where TQueryClauseExpression : IQueryClauseExpression
            where TQueryEndExpression : IQueryEndExpression
        {
            VisitIfNotNull(queryExpression.StartExpression, visitor);
            VisitCollection(queryExpression.Expressions, visitor);
            VisitIfNotNull(queryExpression.EndExpression, visitor);
        }

        public static void VisitQueryFromExpressionChildren<TExpression>(
            IQueryFromExpression<TExpression> queryFromExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(queryFromExpression.Expression, visitor);
        }

        public static void VisitQueryGroupExpressionChildren<TExpression>(
            IQueryGroupExpression<TExpression> queryGroupExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(queryGroupExpression.GroupExpression, visitor);
            VisitIfNotNull(queryGroupExpression.ByExpression, visitor);
        }

        public static void VisitQueryGroupIntoExpressionChildren<TExpression, TIdentiferExpression>(
            IQueryGroupIntoExpression<TExpression, TIdentiferExpression> queryGroupExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
            where TIdentiferExpression : IIdentifierExpression
        {
            VisitQueryGroupExpressionChildren(queryGroupExpression, visitor);
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

        public static void VisitQueryLetExpressionChildren<TExpression>(
            IQueryLetExpression<TExpression> queryLetExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(queryLetExpression.Expression, visitor);
        }

        public static void VisitQueryOrderByExpressionChildren<TOrderingExpression>(
            IQueryOrderByExpression<TOrderingExpression> queryOrderByExpression,
            IGenericExpressionVisitor visitor)
            where TOrderingExpression : IQueryOrderingExpression
        {
            VisitCollection(queryOrderByExpression.Orders, visitor);
        }

        public static void VisitQueryOrderingExpressionChildren<TExpression>(
            IQueryOrderingExpression<TExpression> queryOrderingExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(queryOrderingExpression.Expression, visitor);
        }

        public static void VisitQuerySelectExpressionChildren<TExpression>(
            IQuerySelectExpression<TExpression> querySelectExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(querySelectExpression.Expression, visitor);
        }

        public static void VisitQuerySelectIntoExpressionChildren<TExpression, TIdentifierExpression>(
            IQuerySelectIntoExpression<TExpression, TIdentifierExpression> querySelectExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
            where TIdentifierExpression : IIdentifierExpression
        {
            VisitQuerySelectExpressionChildren(querySelectExpression, visitor);
            VisitIfNotNull(querySelectExpression.IntoExpression, visitor);
        }

        public static void VisitQueryWhereExpressionChildren<TExpression>(
            IQueryWhereExpression<TExpression> queryWhereExpression,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(queryWhereExpression.Expression, visitor);
        }

        public static void VisitRefArgumentChildren<TExpression>(
            IRefArgument<TExpression> refArgument,
            IGenericExpressionVisitor visitor)
            where TExpression : IExpression
        {
            VisitIfNotNull(refArgument.Expression, visitor);
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
