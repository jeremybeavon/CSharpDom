using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableExpressionVisitor
    {
        void Visit(IVisitable<IEditableExpressionVisitor> node);

        void VisitArgument<TExpression>(IEditableArgument<TExpression> argument)
            where TExpression : IEditableExpression;

        void VisitArrayIndexExpression<TExpression, TArgument>(
            IEditableArrayIndexExpression<TExpression, TArgument> arrayIndexExpression)
            where TExpression : IEditableExpression
            where TArgument : IEditableArgument;

        void VisitAwaitExpression<TExpression>(IEditableAwaitExpression<TExpression> awaitExpression)
            where TExpression : IEditableExpression;

        void VisitBinaryOperatorExpression<TExpression>(IEditableBinaryOperatorExpression<TExpression> binaryOperatorExpression)
            where TExpression : IEditableExpression;

        void VisitCastExpression<TTypeReference, TExpression>(
            IEditableCastExpression<TTypeReference, TExpression> castExpression)
            where TTypeReference : IEditableTypeReference
            where TExpression : IEditableExpression;

        void VisitDefaultExpression<TTypeReference>(IEditableDefaultExpression<TTypeReference> defaultExpression)
            where TTypeReference : IEditableTypeReference;

        void VisitDoubleConstantExpression(IEditableDoubleConstantExpression doubleConstantExpression);

        void VisitIdentifierExpression(IEditableIdentifierExpression identifierExpression);

        void VisitIntegerConstantExpression(IEditableIntegerConstantExpression integerConstantExpression);

        void VisitAnonymousMethodExpression<TParameter, TStatement>(
            IEditableAnonymousMethodExpression<TParameter, TStatement> anonymousMethodExpression)
            where TParameter : IEditableAnonymousMethodParameter
            where TStatement : IEditableStatement;

        void VisitAnonymousMethodParameter<TTypeReference>(
            IEditableAnonymousMethodParameter<TTypeReference> anonymousMethodParameter)
            where TTypeReference : IEditableTypeReference;

        void VisitListInitializerExpression<TCreateListExpression, TExpression>(
            IEditableListInitializerExpression<TCreateListExpression, TExpression> listInitializerExpression)
            where TCreateListExpression : IEditableCreateListExpression
            where TExpression : IEditableExpression;

        void VisitMemberExpression<TExpression>(IEditableMemberExpression<TExpression> memberExpression)
            where TExpression : IEditableExpression;

        void VisitMethodCallExpression<TExpression, TArgument>(
            IEditableMethodCallExpression<TExpression, TArgument> methodCallExpression)
            where TExpression : IEditableExpression
            where TArgument : IEditableArgument;

        void VisitNewAnonymousArrayExpression(IEditableNewAnonymousArrayExpression newAnonymousArrayExpression);

        void VisitNewAnonymousTypeExpression(IEditableNewAnonymousTypeExpression newAnonymousTypeExpression);

        void VisitNewArrayExpression<TTypeReference, TExpression>(
            IEditableNewArrayExpression<TTypeReference, TExpression> newArrayExpression)
            where TTypeReference : IEditableTypeReference
            where TExpression : IEditableExpression;

        void VisitNewExpression<TTypeReference, TArgument>(
            IEditableNewExpression<TTypeReference, TArgument> newExpression)
            where TTypeReference : IEditableTypeReference
            where TArgument : IEditableArgument;

        void VisitNullExpression(IEditableNullExpression nullExpression);

        void VisitObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>(
            IEditableObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> objectInitializerExpression)
            where TCreateObjectExpression : IEditableCreateObjectExpression
            where TExpression : IEditableExpression
            where TObjectInitializer : IHasEditableObjectInitializers<TExpression, TObjectInitializer>;

        void VisitOutArgument<TExpression>(IEditableOutArgument<TExpression> outArgument)
            where TExpression : IEditableExpression;

        void VisitParenthesisExpression<TExpression>(IEditableParenthesisExpression<TExpression> parenthesisExpression)
            where TExpression : IEditableExpression;

        void VisitQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>(
            IEditableQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> queryExpression)
            where TQueryFromExpression : IEditableQueryFromExpression
            where TQueryClauseExpression : IEditableQueryClauseExpression
            where TQueryEndExpression : IEditableQueryEndExpression;

        void VisitQueryFromExpression<TExpression>(IEditableQueryFromExpression<TExpression> queryFromExpression)
            where TExpression : IEditableExpression;

        void VisitQueryGroupExpression<TExpression>(IEditableQueryGroupExpression<TExpression> queryGroupExpression)
            where TExpression : IEditableExpression;

        void VisitQueryGroupIntoExpression<TExpression, TIdentiferExpression>(
            IEditableQueryGroupIntoExpression<TExpression, TIdentiferExpression> queryGroupIntoExpression)
            where TExpression : IEditableExpression
            where TIdentiferExpression : IEditableIdentifierExpression;

        void VisitQueryJoinExpression<TExpression>(IEditableQueryJoinExpression<TExpression> queryJoinExpression)
            where TExpression : IEditableExpression;

        void VisitQueryLetExpression<TExpression>(IEditableQueryLetExpression<TExpression> queryLetExpression)
            where TExpression : IEditableExpression;

        void VisitQueryOrderByExpression<TOrderingExpression>(
            IEditableQueryOrderByExpression<TOrderingExpression> queryOrderByExpression)
            where TOrderingExpression : IEditableQueryOrderingExpression;

        void VisitQueryOrderingExpression<TExpression>(IEditableQueryOrderingExpression<TExpression> queryOrderingExpression)
            where TExpression : IEditableExpression;

        void VisitQuerySelectExpression<TExpression>(IEditableQuerySelectExpression<TExpression> querySelectExpression)
            where TExpression : IEditableExpression;

        void VisitQuerySelectIntoExpression<TExpression, TIdentifierExpression>(
            IEditableQuerySelectIntoExpression<TExpression, TIdentifierExpression> querySelectIntoExpression)
            where TExpression : IEditableExpression
            where TIdentifierExpression : IEditableIdentifierExpression;

        void VisitQueryWhereExpression<TExpression>(IEditableQueryWhereExpression<TExpression> queryWhereExpression)
            where TExpression : IEditableExpression;

        void VisitRawExpression(IEditableRawExpression rawExpression);

        void VisitRefArgument<TExpression>(IEditableRefArgument<TExpression> refArgument)
            where TExpression : IEditableExpression;

        void VisitStringConstantExpression(IEditableStringConstantExpression stringConstantExpression);

        void VisitTernaryOperatorExpression<TExpression>(
            IEditableTernaryOperatorExpression<TExpression> ternaryOperatorExpression)
            where TExpression : IEditableExpression;

        void VisitThisExpression(IEditableThisExpression thisExpression);

        void VisitTypeofExpression<TTypeReference>(IEditableTypeofExpression<TTypeReference> typeofExpression)
            where TTypeReference : IEditableTypeReference;

        void VisitUnaryOperatorExpression<TExpression>(IEditableUnaryOperatorExpression<TExpression> unaryOperatorExpression)
            where TExpression : IEditableExpression;
    }
}