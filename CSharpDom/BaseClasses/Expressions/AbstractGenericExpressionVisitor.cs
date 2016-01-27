using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractGenericExpressionVisitor : IGenericExpressionVisitor
    {
        public virtual void VisitArrayIndexExpression<TExpression>(IArrayIndexExpression<TExpression> arrayIndexExpression)
            where TExpression : IExpression
        {
            arrayIndexExpression.AcceptChildren(this);
        }

        public virtual void VisitAwaitExpression<TExpression>(IAwaitExpression<TExpression> awaitExpression)
            where TExpression : IExpression
        {
            awaitExpression.AcceptChildren(this);
        }

        public virtual void VisitBinaryOperatorExpression<TExpression>(
            IBinaryOperatorExpression<TExpression> binaryOperatorExpression)
            where TExpression : IExpression
        {
            binaryOperatorExpression.AcceptChildren(this);
        }

        public virtual void VisitCastExpression<TTypeReference, TExpression>(
            ICastExpression<TTypeReference, TExpression> castExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            castExpression.AcceptChildren(this);
        }

        public virtual void VisitDefaultExpression<TTypeReference>(IDefaultExpression<TTypeReference> defaultExpression)
            where TTypeReference : ITypeReference
        {
            defaultExpression.AcceptChildren(this);
        }

        public virtual void VisitDoubleConstantExpression(IDoubleConstantExpression doubleConstantExpression)
        {
            doubleConstantExpression.AcceptChildren(this);
        }

        public virtual void VisitIdentifierExpression(IIdentifierExpression identifierExpression)
        {
            identifierExpression.AcceptChildren(this);
        }

        public virtual void VisitIntegerConstantExpression(IIntegerConstantExpression integerConstantExpression)
        {
            integerConstantExpression.AcceptChildren(this);
        }

        public virtual void VisitLambdaExpression<TParameter, TStatement>(ILambdaExpression<TParameter, TStatement> lambdaExpression)
            where TParameter : IParameter
            where TStatement : IStatement
        {
            lambdaExpression.AcceptChildren(this);
        }

        public virtual void VisitListInitializerExpression<TCreateListExpression, TExpression>(
            IListInitializerExpression<TCreateListExpression, TExpression> listInitializerExpression)
            where TCreateListExpression : ICreateListExpression
            where TExpression : IExpression
        {
            listInitializerExpression.AcceptChildren(this);
        }

        public virtual void VisitMemberExpression<TExpression>(IMemberExpression<TExpression> memberExpression)
            where TExpression : IExpression
        {
            memberExpression.AcceptChildren(this);
        }

        public virtual void VisitMethodCallExpression<TExpression>(IMethodCallExpression<TExpression> methodCallExpression)
            where TExpression : IExpression
        {
            methodCallExpression.AcceptChildren(this);
        }

        public virtual void VisitNewAnonymousArrayExpression(INewAnonymousArrayExpression newAnonymousArrayExpression)
        {
            newAnonymousArrayExpression.AcceptChildren(this);
        }

        public virtual void VisitNewAnonymousTypeExpression(INewAnonymousTypeExpression newAnonymousTypeExpression)
        {
            newAnonymousTypeExpression.AcceptChildren(this);
        }

        public virtual void VisitNewArrayExpression<TTypeReference, TExpression>(
            INewArrayExpression<TTypeReference, TExpression> newArrayExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            newArrayExpression.AcceptChildren(this);
        }

        public virtual void VisitNewExpression<TTypeReference, TExpression>(
            INewExpression<TTypeReference, TExpression> newExpression)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            newExpression.AcceptChildren(this);
        }

        public virtual void VisitNullExpression(INullExpression nullExpression)
        {
            nullExpression.AcceptChildren(this);
        }

        public virtual void VisitObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression>(
            IObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression> objectInitializerExpression)
            where TCreateObjectExpression : ICreateObjectExpression
            where TBinaryOperatorExpression : IBinaryOperatorExpression
        {
            objectInitializerExpression.AcceptChildren(this);
        }

        public virtual void VisitOutExpression<TExpression>(IOutExpression<TExpression> outExpression)
            where TExpression : IExpression
        {
            outExpression.AcceptChildren(this);
        }

        public virtual void VisitParenthesisExpression<TExpression>(IParenthesisExpression<TExpression> parenthesisExpression)
            where TExpression : IExpression
        {
            parenthesisExpression.AcceptChildren(this);
        }

        public virtual void VisitQueryFromExpression<TIdentifierExpression, TExpression>(
            IQueryFromExpression<TIdentifierExpression, TExpression> queryFromExpression)
            where TIdentifierExpression : IIdentifierExpression
            where TExpression : IExpression
        {
            queryFromExpression.AcceptChildren(this);
        }

        public virtual void VisitQueryGroupExpression<TExpression, TIdentiferExpression>(
            IQueryGroupExpression<TExpression, TIdentiferExpression> queryGroupExpression)
            where TExpression : IExpression
            where TIdentiferExpression : IIdentifierExpression
        {
            queryGroupExpression.AcceptChildren(this);
        }

        public virtual void VisitQueryJoinExpression<TExpression, TIdentifierExpresion>(
            IQueryJoinExpression<TExpression, TIdentifierExpresion> queryJoinExpression)
            where TExpression : IExpression
            where TIdentifierExpresion : IIdentifierExpression
        {
            queryJoinExpression.AcceptChildren(this);
        }

        public virtual void VisitQueryLetExpression<TBinaryOperatorExpression>(
            IQueryLetExpression<TBinaryOperatorExpression> queryLetExpression)
            where TBinaryOperatorExpression : IBinaryOperatorExpression
        {
            queryLetExpression.AcceptChildren(this);
        }

        public virtual void VisitQueryOrderByExpression<TExpression>(
            IQueryOrderByExpression<TExpression> queryOrderByExpression)
            where TExpression : IExpression
        {
            queryOrderByExpression.AcceptChildren(this);
        }

        public virtual void VisitQuerySelectExpression<TExpression>(
            IQuerySelectExpression<TExpression> querySelectExpression)
            where TExpression : IExpression
        {
            querySelectExpression.AcceptChildren(this);
        }

        public virtual void VisitQueryWhereExpression<TExpression>(
            IQueryWhereExpression<TExpression> queryWhereExpression)
            where TExpression : IExpression
        {
            queryWhereExpression.AcceptChildren(this);
        }

        public virtual void VisitRefExpression<TExpression>(IRefExpression<TExpression> refExpression)
            where TExpression : IExpression
        {
            refExpression.AcceptChildren(this);
        }

        public virtual void VisitStringConstantExpression(IStringConstantExpression stringConstantExpression)
        {
            stringConstantExpression.AcceptChildren(this);
        }

        public virtual void VisitTernaryOperatorExpression<TExpression>(
            ITernaryOperatorExpression<TExpression> ternaryOperatorExpression)
            where TExpression : IExpression
        {
            ternaryOperatorExpression.AcceptChildren(this);
        }

        public virtual void VisitTypeofExpression<TTypeReference>(ITypeofExpression<TTypeReference> typeofExpression)
            where TTypeReference : ITypeReference
        {
            typeofExpression.AcceptChildren(this);
        }

        public virtual void VisitUnaryOperatorExpression<TExpression>(IUnaryOperatorExpression<TExpression> unaryOperatorExpression)
            where TExpression : IExpression
        {
            unaryOperatorExpression.AcceptChildren(this);
        }
    }
}
