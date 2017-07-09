using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Expressions
{
    public interface IGenericExpressionVisitor
    {
        void Visit(IVisitable<IGenericExpressionVisitor> node);

        void VisitArrayIndexExpression<TExpression>(IArrayIndexExpression<TExpression> arrayIndexExpression)
            where TExpression : IExpression;

        void VisitAwaitExpression<TExpression>(IAwaitExpression<TExpression> awaitExpression)
            where TExpression : IExpression;

        void VisitBinaryOperatorExpression<TExpression>(IBinaryOperatorExpression<TExpression> binaryOperatorExpression)
            where TExpression : IExpression;

        void VisitCastExpression<TTypeReference, TExpression>(ICastExpression<TTypeReference, TExpression> castExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitDefaultExpression<TTypeReference>(IDefaultExpression<TTypeReference> defaultExpression)
            where TTypeReference : ITypeReference;

        void VisitDoubleConstantExpression(IDoubleConstantExpression doubleConstantExpression);

        void VisitIdentifierExpression(IIdentifierExpression identifierExpression);

        void VisitIntegerConstantExpression(IIntegerConstantExpression integerConstantExpression);

        void VisitAnonymousMethodExpression<TParameter, TStatement>(
            IAnonymousMethodExpression<TParameter, TStatement> anonymousMethodExpression)
            where TParameter : IAnonymousMethodParameter
            where TStatement : IStatement;

        void VisitAnonymousMethodParameter<TTypeReference>(
            IAnonymousMethodParameter<TTypeReference> anonymousMethodParameter)
            where TTypeReference : ITypeReference;

        void VisitListInitializerExpression<TCreateListExpression, TExpression>(
            IListInitializerExpression<TCreateListExpression, TExpression> listInitializerExpression)
            where TCreateListExpression : ICreateListExpression
            where TExpression : IExpression;

        void VisitMemberExpression<TExpression>(IMemberExpression<TExpression> memberExpression)
            where TExpression : IExpression;

        void VisitMethodCallExpression<TExpression>(IMethodCallExpression<TExpression> methodCallExpression)
            where TExpression : IExpression;

        void VisitNewAnonymousArrayExpression(INewAnonymousArrayExpression newAnonymousArrayExpression);

        void VisitNewAnonymousTypeExpression(INewAnonymousTypeExpression newAnonymousTypeExpression);

        void VisitNewArrayExpression<TTypeReference, TExpression>(
            INewArrayExpression<TTypeReference, TExpression> newArrayExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitNewExpression<TTypeReference, TExpression>(INewExpression<TTypeReference, TExpression> newExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitNullExpression(INullExpression nullExpression);

        void VisitObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>(
            IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> objectInitializerExpression)
            where TCreateObjectExpression : ICreateObjectExpression
            where TExpression : IExpression
            where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>;

        void VisitOutExpression<TExpression>(IOutExpression<TExpression> outExpression)
            where TExpression : IExpression;

        void VisitParenthesisExpression<TExpression>(IParenthesisExpression<TExpression> parenthesisExpression)
            where TExpression : IExpression;

        void VisitQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>(
            IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> queryExpression)
            where TQueryFromExpression : IQueryFromExpression
            where TQueryClauseExpression : IQueryClauseExpression
            where TQueryEndExpression : IQueryEndExpression;

        void VisitQueryFromExpression<TExpression>(
            IQueryFromExpression<TExpression> queryFromExpression)
            where TExpression : IExpression;

        void VisitQueryGroupExpression<TExpression>(
            IQueryGroupExpression<TExpression> queryGroupExpression)
            where TExpression : IExpression;

        void VisitQueryGroupIntoExpression<TExpression, TIdentiferExpression>(
            IQueryGroupIntoExpression<TExpression, TIdentiferExpression> queryGroupIntoExpression)
            where TExpression : IExpression
            where TIdentiferExpression : IIdentifierExpression;

        void VisitQueryJoinExpression<TExpression>(
            IQueryJoinExpression<TExpression> queryJoinExpression)
            where TExpression : IExpression;

        void VisitQueryLetExpression<TExpression>(IQueryLetExpression<TExpression> queryLetExpression)
            where TExpression : IExpression;

        void VisitQueryOrderByExpression<TOrderingExpression>(
            IQueryOrderByExpression<TOrderingExpression> queryOrderByExpression)
            where TOrderingExpression : IQueryOrderingExpression;

        void VisitQueryOrderingExpression<TExpression>(IQueryOrderingExpression<TExpression> queryOrderingExpression)
            where TExpression : IExpression;

        void VisitQuerySelectExpression<TExpression>(IQuerySelectExpression<TExpression> querySelectExpression)
            where TExpression : IExpression;

        void VisitQuerySelectIntoExpression<TExpression, TIdentifierExpression>(
            IQuerySelectIntoExpression<TExpression, TIdentifierExpression> querySelectIntoExpression)
            where TExpression : IExpression
            where TIdentifierExpression : IIdentifierExpression;

        void VisitQueryWhereExpression<TExpression>(IQueryWhereExpression<TExpression> queryWhereExpression)
            where TExpression : IExpression;

        void VisitRawExpression(IRawExpression rawExpression);

        void VisitRefExpression<TExpression>(IRefExpression<TExpression> refExpression)
            where TExpression : IExpression;

        void VisitStringConstantExpression(IStringConstantExpression stringConstantExpression);

        void VisitTernaryOperatorExpression<TExpression>(ITernaryOperatorExpression<TExpression> ternaryOperatorExpression)
            where TExpression : IExpression;

        void VisitTypeofExpression<TTypeReference>(ITypeofExpression<TTypeReference> typeofExpression)
            where TTypeReference : ITypeReference;

        void VisitUnaryOperatorExpression<TExpression>(IUnaryOperatorExpression<TExpression> unaryOperatorExpression)
            where TExpression : IExpression;
    }
}
