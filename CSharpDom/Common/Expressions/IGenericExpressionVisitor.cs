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
            where TParameter : IParameter
            where TStatement : IStatement;

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

        void VisitObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression>(
            IObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression> objectInitializerExpression)
            where TCreateObjectExpression : ICreateObjectExpression
            where TBinaryOperatorExpression : IBinaryOperatorExpression;

        void VisitOutExpression<TExpression>(IOutExpression<TExpression> outExpression)
            where TExpression : IExpression;

        void VisitParenthesisExpression<TExpression>(IParenthesisExpression<TExpression> parenthesisExpression)
            where TExpression : IExpression;

        void VisitQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression>(
            IQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression> queryFromExpression)
            where TIdentifierExpression : IIdentifierExpression
            where TExpression : IExpression
            where TQueryExpression : IQueryExpression;

        void VisitQueryGroupExpression<TExpression, TIdentiferExpression>(
            IQueryGroupExpression<TExpression, TIdentiferExpression> queryGroupExpression)
            where TExpression : IExpression
            where TIdentiferExpression : IIdentifierExpression;

        void VisitQueryJoinExpression<TExpression, TIdentifierExpresion>(
            IQueryJoinExpression<TExpression, TIdentifierExpresion> queryJoinExpression)
            where TExpression : IExpression
            where TIdentifierExpresion : IIdentifierExpression;

        void VisitQueryLetExpression<TBinaryOperatorExpression>(IQueryLetExpression<TBinaryOperatorExpression> queryLetExpression)
            where TBinaryOperatorExpression : IBinaryOperatorExpression;

        void VisitQueryOrderByExpression<TExpression>(IQueryOrderByExpression<TExpression> queryOrderByExpression)
            where TExpression : IExpression;

        void VisitQuerySelectExpression<TExpression>(IQuerySelectExpression<TExpression> querySelectExpression)
            where TExpression : IExpression;

        void VisitQueryWhereExpression<TExpression>(IQueryWhereExpression<TExpression> queryWhereExpression)
            where TExpression : IExpression;

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
