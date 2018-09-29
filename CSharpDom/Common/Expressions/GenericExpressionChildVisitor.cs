using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public static class GenericExpressionChildVisitor
    {
        public static void VisitArgumentChildren<TArgument, TExpression, TVisitor>(TArgument argument, TVisitor visitor)
            where TArgument : IArgument<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(argument.Expression, visitor);
        }

        public static void VisitArrayIndexExpressionChildren<TArrayIndexExpression, TExpression, TArgument, TVisitor>(
            TArrayIndexExpression arrayIndexExpression,
            TVisitor visitor)
            where TArrayIndexExpression : IArrayIndexExpression<TExpression, TArgument>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TArgument : IArgument, IVisitable<TVisitor>
        {
            VisitIfNotNull(arrayIndexExpression.Array, visitor);
            VisitCollection(arrayIndexExpression.Indexes, visitor);
        }

        public static void VisitAwaitExpressionChildren<TAwaitExpression, TExpression, TVisitor>(
            TAwaitExpression awaitExpression,
            TVisitor visitor)
            where TAwaitExpression : IAwaitExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(awaitExpression.Expression, visitor);
        }

        public static void VisitBinaryOperatorExpressionChildren<TBinaryOperatorExpression, TExpression, TVisitor>(
            TBinaryOperatorExpression binaryOperatorExpression,
            TVisitor visitor)
            where TBinaryOperatorExpression : IBinaryOperatorExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(binaryOperatorExpression.Left, visitor);
            VisitIfNotNull(binaryOperatorExpression.Right, visitor);
        }

        public static void VisitCastExpressionChildren<TCastExpression, TTypeReference, TExpression, TVisitor>(
            TCastExpression castExpression,
            TVisitor visitor)
            where TCastExpression : ICastExpression<TTypeReference, TExpression>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(castExpression.Expression, visitor);
        }

        public static void VisitAnonymousMethodExpressionChildren<TAnonymousMethodExpression, TParameter, TStatement, TVisitor>(
            TAnonymousMethodExpression anonymousMethodExpression,
            TVisitor visitor)
            where TAnonymousMethodExpression : IAnonymousMethodExpression<TParameter, TStatement>
            where TParameter : IAnonymousMethodParameter, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitCollection(anonymousMethodExpression.Parameters, visitor);
        }

        public static void VisitLambdaExpressionChildren<TLambdaExpression, TExpression, TVisitor>(
            TLambdaExpression lambdaExpression,
            TVisitor visitor)
            where TLambdaExpression : ILambdaExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(lambdaExpression.Expression, visitor);
        }

        public static void VisitListInitializerExpressionChildren<TListInitializerExpression, TCreateListExpression, TExpression, TVisitor>(
            TListInitializerExpression listInitializerExpression,
            TVisitor visitor)
            where TListInitializerExpression : IListInitializerExpression<TCreateListExpression, TExpression>
            where TCreateListExpression : ICreateListExpression, IVisitable<TVisitor>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(listInitializerExpression.CreateListExpression, visitor);
            foreach (IReadOnlyList<TExpression> initialValues in listInitializerExpression.InitialValues)
            {
                VisitCollection(initialValues, visitor);
            }
        }

        public static void VisitGenericMemberExpressionChildren<TGenericMemberExpression, TExpression, TTypeReference, TVisitor>(
            TGenericMemberExpression memberExpression,
            TVisitor visitor)
            where TGenericMemberExpression : IGenericMemberExpression<TExpression, TTypeReference>
            where TTypeReference : ITypeReference
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(memberExpression.ObjectExpression, visitor);
        }

        public static void VisitMemberExpressionChildren<TMemberExpression, TExpression, TVisitor>(
            TMemberExpression memberExpression,
            TVisitor visitor)
            where TMemberExpression : IMemberExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(memberExpression.ObjectExpression, visitor);
        }

        public static void VisitMethodCallExpressionChildren<TMethodCallExpression, TExpression, TArgument, TVisitor>(
            TMethodCallExpression methodCallExpression,
            TVisitor visitor)
            where TMethodCallExpression : IMethodCallExpression<TExpression, TArgument>
            where TExpression : IGenericExpression, IVisitable<TVisitor>
            where TArgument : IArgument, IVisitable<TVisitor>
        {
            VisitIfNotNull(methodCallExpression.Expression, visitor);
            VisitCollection(methodCallExpression.Parameters, visitor);
        }

        public static void VisitNewArrayExpressionChildren<TNewArrayExpression, TTypeReference, TExpression, TVisitor>(
            TNewArrayExpression newArrayExpression,
            TVisitor visitor)
            where TNewArrayExpression : INewArrayExpression<TTypeReference, TExpression>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitCollection(newArrayExpression.InitialSizeExpressions, visitor);
        }

        public static void VisitNewExpressionChildren<TNewExpression, TTypeReference, TArgument, TVisitor>(
            TNewExpression newExpression,
            TVisitor visitor)
            where TNewExpression : INewExpression<TTypeReference, TArgument>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TArgument : IArgument, IVisitable<TVisitor>
        {
            VisitCollection(newExpression.Parameters, visitor);
        }

        public static void VisitObjectInitializerExpressionChildren<TObjectInitializerExpression, TCreateObjectExpression, TExpression, TObjectInitializer, TVisitor>(
            TObjectInitializerExpression objectInitializerExpression,
            TVisitor visitor)
            where TObjectInitializerExpression : IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>
            where TCreateObjectExpression : ICreateObjectExpression, IVisitable<TVisitor>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>, IVisitable<TVisitor>
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

        public static void VisitOutArgumentChildren<TOutArgument, TExpression, TVisitor>(
            TOutArgument outArgument,
            TVisitor visitor)
            where TOutArgument : IOutArgument<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(outArgument.Expression, visitor);
        }

        public static void VisitParenthesisExpressionChildren<TParenthesisExpression, TExpression, TVisitor>(
            TParenthesisExpression parenthesisExpression,
            TVisitor visitor)
            where TParenthesisExpression : IParenthesisExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(parenthesisExpression.Expression, visitor);
        }

        public static void VisitQueryExpressionChildren<TQueryExpression, TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression, TVisitor>(
            TQueryExpression queryExpression,
            TVisitor visitor)
            where TQueryExpression : IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>
            where TQueryFromExpression : IQueryFromExpression, IVisitable<TVisitor>
            where TQueryClauseExpression : IQueryClauseExpression, IVisitable<TVisitor>
            where TQueryEndExpression : IQueryEndExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(queryExpression.StartExpression, visitor);
            VisitCollection(queryExpression.Expressions, visitor);
            VisitIfNotNull(queryExpression.EndExpression, visitor);
        }

        public static void VisitQueryFromExpressionChildren<TQueryFromExpression, TExpression, TVisitor>(
            TQueryFromExpression queryFromExpression,
            TVisitor visitor)
            where TQueryFromExpression : IQueryFromExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(queryFromExpression.Expression, visitor);
        }

        public static void VisitQueryGroupExpressionChildren<TQueryGroupExpression, TExpression, TVisitor>(
            TQueryGroupExpression queryGroupExpression,
            TVisitor visitor)
            where TQueryGroupExpression : IQueryGroupExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(queryGroupExpression.GroupExpression, visitor);
            VisitIfNotNull(queryGroupExpression.ByExpression, visitor);
        }

        public static void VisitQueryGroupIntoExpressionChildren<TQueryGroupIntoExpression, TExpression, TIdentiferExpression, TVisitor>(
            TQueryGroupIntoExpression queryGroupExpression,
            TVisitor visitor)
            where TQueryGroupIntoExpression : IQueryGroupIntoExpression<TExpression, TIdentiferExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TIdentiferExpression : IIdentifierExpression, IVisitable<TVisitor>
        {
            VisitQueryGroupExpressionChildren<TQueryGroupIntoExpression, TExpression, TVisitor>(queryGroupExpression, visitor);
            VisitIfNotNull(queryGroupExpression.IntoExpression, visitor);
        }

        public static void VisitQueryJoinExpressionChildren<TQueryJoinExpression, TExpression, TVisitor>(
            TQueryJoinExpression queryJoinExpression,
            TVisitor visitor)
            where TQueryJoinExpression : IQueryJoinExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(queryJoinExpression.InExpression, visitor);
            VisitIfNotNull(queryJoinExpression.OnExpression, visitor);
            VisitIfNotNull(queryJoinExpression.EqualsExpression, visitor);
        }

        public static void VisitQueryLetExpressionChildren<TQueryLetExpression, TExpression, TVisitor>(
            TQueryLetExpression queryLetExpression,
            TVisitor visitor)
            where TQueryLetExpression : IQueryLetExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(queryLetExpression.Expression, visitor);
        }

        public static void VisitQueryOrderByExpressionChildren<TQueryOrderByExpression, TOrderingExpression, TVisitor>(
            TQueryOrderByExpression queryOrderByExpression,
            TVisitor visitor)
            where TQueryOrderByExpression : IQueryOrderByExpression<TOrderingExpression>
            where TOrderingExpression : IQueryOrderingExpression, IVisitable<TVisitor>
        {
            VisitCollection(queryOrderByExpression.Orders, visitor);
        }

        public static void VisitQueryOrderingExpressionChildren<TQueryOrderingExpression, TExpression, TVisitor>(
            TQueryOrderingExpression queryOrderingExpression,
            TVisitor visitor)
            where TQueryOrderingExpression : IQueryOrderingExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(queryOrderingExpression.Expression, visitor);
        }

        public static void VisitQuerySelectExpressionChildren<TQuerySelectExpression, TExpression, TVisitor>(
            TQuerySelectExpression querySelectExpression,
            TVisitor visitor)
            where TQuerySelectExpression : IQuerySelectExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(querySelectExpression.Expression, visitor);
        }

        public static void VisitQuerySelectIntoExpressionChildren<TQuerySelectIntoExpression, TExpression, TIdentifierExpression, TVisitor>(
            TQuerySelectIntoExpression querySelectExpression,
            TVisitor visitor)
            where TQuerySelectIntoExpression : IQuerySelectIntoExpression<TExpression, TIdentifierExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TIdentifierExpression : IIdentifierExpression, IVisitable<TVisitor>
        {
            VisitQuerySelectExpressionChildren<TQuerySelectIntoExpression, TExpression, TVisitor>(querySelectExpression, visitor);
            VisitIfNotNull(querySelectExpression.IntoExpression, visitor);
        }

        public static void VisitQueryWhereExpressionChildren<TQueryWhereExpression, TExpression, TVisitor>(
            TQueryWhereExpression queryWhereExpression,
            TVisitor visitor)
            where TQueryWhereExpression : IQueryWhereExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(queryWhereExpression.Expression, visitor);
        }

        public static void VisitRefArgumentChildren<TRefArgument, TExpression, TVisitor>(
            TRefArgument refArgument,
            TVisitor visitor)
            where TRefArgument : IRefArgument<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(refArgument.Expression, visitor);
        }

        public static void VisitTernaryOperatorExpressionChildren<TTernaryOperatorExpression, TExpression, TVisitor>(
            TTernaryOperatorExpression ternaryOperatorExpression,
            TVisitor visitor)
            where TTernaryOperatorExpression : ITernaryOperatorExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(ternaryOperatorExpression.Left, visitor);
            VisitIfNotNull(ternaryOperatorExpression.Middle, visitor);
            VisitIfNotNull(ternaryOperatorExpression.Right, visitor);
        }

        public static void VisitUnaryOperatorExpressionChildren<TUnaryOperatorExpression, TExpression, TVisitor>(
            TUnaryOperatorExpression unaryOperatorExpression,
            TVisitor visitor)
            where TUnaryOperatorExpression : IUnaryOperatorExpression<TExpression>
            where TExpression : IExpression, IVisitable<TVisitor>
        {
            VisitIfNotNull(unaryOperatorExpression.Operand, visitor);
        }

        private static void VisitCollection<T, TVisitor>(IReadOnlyCollection<T> collection, TVisitor visitor)
            where T : IVisitable<TVisitor>
        {
            GenericChildVisitor.VisitCollection(collection, visitor);
        }

        private static void VisitIfNotNull<TVisitor>(IVisitable<TVisitor> visitable, TVisitor visitor)
        {
            GenericChildVisitor.VisitIfNotNull(visitable, visitor);
        }
    }
}