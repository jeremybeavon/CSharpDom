using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractGenericExpressionVisitor : IGenericExpressionVisitor
    {
        public virtual void Visit(IVisitable<IGenericExpressionVisitor> node)
        {
            node.AcceptChildren(this);
        }

        public virtual void VisitArrayIndexExpression<TExpression>(IArrayIndexExpression<TExpression> arrayIndexExpression)
            where TExpression : IExpression
        {
            Visit(arrayIndexExpression);
        }

        public virtual void VisitAwaitExpression<TExpression>(IAwaitExpression<TExpression> awaitExpression)
            where TExpression : IExpression
        {
            Visit(awaitExpression);
        }

        public virtual void VisitBinaryOperatorExpression<TExpression>(
            IBinaryOperatorExpression<TExpression> binaryOperatorExpression)
            where TExpression : IExpression
        {
            Visit(binaryOperatorExpression);
        }

        public virtual void VisitCastExpression<TTypeReference, TExpression>(
            ICastExpression<TTypeReference, TExpression> castExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            Visit(castExpression);
        }

        public virtual void VisitDefaultExpression<TTypeReference>(IDefaultExpression<TTypeReference> defaultExpression)
            where TTypeReference : ITypeReference
        {
            Visit(defaultExpression);
        }

        public virtual void VisitDoubleConstantExpression(IDoubleConstantExpression doubleConstantExpression)
        {
            Visit(doubleConstantExpression);
        }

        public virtual void VisitIdentifierExpression(IIdentifierExpression identifierExpression)
        {
            Visit(identifierExpression);
        }

        public virtual void VisitIntegerConstantExpression(IIntegerConstantExpression integerConstantExpression)
        {
            Visit(integerConstantExpression);
        }

        public virtual void VisitLambdaExpression<TParameter, TStatement>(ILambdaExpression<TParameter, TStatement> lambdaExpression)
            where TParameter : IParameter
            where TStatement : IStatement
        {
            Visit(lambdaExpression);
        }

        public virtual void VisitListInitializerExpression<TCreateListExpression, TExpression>(
            IListInitializerExpression<TCreateListExpression, TExpression> listInitializerExpression)
            where TCreateListExpression : ICreateListExpression
            where TExpression : IExpression
        {
            Visit(listInitializerExpression);
        }

        public virtual void VisitMemberExpression<TExpression>(IMemberExpression<TExpression> memberExpression)
            where TExpression : IExpression
        {
            Visit(memberExpression);
        }

        public virtual void VisitMethodCallExpression<TExpression>(IMethodCallExpression<TExpression> methodCallExpression)
            where TExpression : IExpression
        {
            Visit(methodCallExpression);
        }

        public virtual void VisitNewAnonymousArrayExpression(INewAnonymousArrayExpression newAnonymousArrayExpression)
        {
            Visit(newAnonymousArrayExpression);
        }

        public virtual void VisitNewAnonymousTypeExpression(INewAnonymousTypeExpression newAnonymousTypeExpression)
        {
            Visit(newAnonymousTypeExpression);
        }

        public virtual void VisitNewArrayExpression<TTypeReference, TExpression>(
            INewArrayExpression<TTypeReference, TExpression> newArrayExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            Visit(newArrayExpression);
        }

        public virtual void VisitNewExpression<TTypeReference, TExpression>(
            INewExpression<TTypeReference, TExpression> newExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            Visit(newExpression);
        }

        public virtual void VisitNullExpression(INullExpression nullExpression)
        {
            Visit(nullExpression);
        }

        public virtual void VisitObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression>(
            IObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression> objectInitializerExpression)
            where TCreateObjectExpression : ICreateObjectExpression
            where TBinaryOperatorExpression : IBinaryOperatorExpression
        {
            Visit(objectInitializerExpression);
        }

        public virtual void VisitOutExpression<TExpression>(IOutExpression<TExpression> outExpression)
            where TExpression : IExpression
        {
            Visit(outExpression);
        }

        public virtual void VisitParenthesisExpression<TExpression>(IParenthesisExpression<TExpression> parenthesisExpression)
            where TExpression : IExpression
        {
            Visit(parenthesisExpression);
        }

        public virtual void VisitQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression>(
            IQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression> queryFromExpression)
            where TIdentifierExpression : IIdentifierExpression
            where TExpression : IExpression
            where TQueryExpression : IQueryExpression
        {
            Visit(queryFromExpression);
        }

        public virtual void VisitQueryGroupExpression<TExpression, TIdentiferExpression>(
            IQueryGroupExpression<TExpression, TIdentiferExpression> queryGroupExpression)
            where TExpression : IExpression
            where TIdentiferExpression : IIdentifierExpression
        {
            Visit(queryGroupExpression);
        }

        public virtual void VisitQueryJoinExpression<TExpression, TIdentifierExpresion>(
            IQueryJoinExpression<TExpression, TIdentifierExpresion> queryJoinExpression)
            where TExpression : IExpression
            where TIdentifierExpresion : IIdentifierExpression
        {
            Visit(queryJoinExpression);
        }

        public virtual void VisitQueryLetExpression<TBinaryOperatorExpression>(
            IQueryLetExpression<TBinaryOperatorExpression> queryLetExpression)
            where TBinaryOperatorExpression : IBinaryOperatorExpression
        {
            Visit(queryLetExpression);
        }

        public virtual void VisitQueryOrderByExpression<TExpression>(
            IQueryOrderByExpression<TExpression> queryOrderByExpression)
            where TExpression : IExpression
        {
            Visit(queryOrderByExpression);
        }

        public virtual void VisitQuerySelectExpression<TExpression>(
            IQuerySelectExpression<TExpression> querySelectExpression)
            where TExpression : IExpression
        {
            Visit(querySelectExpression);
        }

        public virtual void VisitQueryWhereExpression<TExpression>(
            IQueryWhereExpression<TExpression> queryWhereExpression)
            where TExpression : IExpression
        {
            Visit(queryWhereExpression);
        }

        public virtual void VisitRefExpression<TExpression>(IRefExpression<TExpression> refExpression)
            where TExpression : IExpression
        {
            Visit(refExpression);
        }

        public virtual void VisitStringConstantExpression(IStringConstantExpression stringConstantExpression)
        {
            Visit(stringConstantExpression);
        }

        public virtual void VisitTernaryOperatorExpression<TExpression>(
            ITernaryOperatorExpression<TExpression> ternaryOperatorExpression)
            where TExpression : IExpression
        {
            Visit(ternaryOperatorExpression);
        }

        public virtual void VisitTypeofExpression<TTypeReference>(ITypeofExpression<TTypeReference> typeofExpression)
            where TTypeReference : ITypeReference
        {
            Visit(typeofExpression);
        }

        public virtual void VisitUnaryOperatorExpression<TExpression>(IUnaryOperatorExpression<TExpression> unaryOperatorExpression)
            where TExpression : IExpression
        {
            Visit(unaryOperatorExpression);
        }
    }
}
