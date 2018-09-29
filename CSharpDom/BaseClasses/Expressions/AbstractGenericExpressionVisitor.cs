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

        public virtual void VisitArrayIndexExpression<TExpression, TArgument>(
            IArrayIndexExpression<TExpression, TArgument> arrayIndexExpression)
            where TExpression : IExpression
            where TArgument : IArgument
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

        public virtual void VisitAnonymousMethodExpression<TParameter, TStatement>(
            IAnonymousMethodExpression<TParameter, TStatement> anonymousMethod)
            where TParameter : IAnonymousMethodParameter
            where TStatement : IStatement
        {
            Visit(anonymousMethod);
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

        public virtual void VisitMethodCallExpression<TExpression, TArgument>(
            IMethodCallExpression<TExpression, TArgument> methodCallExpression)
            where TExpression : IGenericExpression
            where TArgument : IArgument
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

        public virtual void VisitNewExpression<TTypeReference, TArgument>(
            INewExpression<TTypeReference, TArgument> newExpression)
            where TTypeReference : ITypeReference
            where TArgument : IArgument
        {
            Visit(newExpression);
        }

        public virtual void VisitNullExpression(INullExpression nullExpression)
        {
            Visit(nullExpression);
        }

        public virtual void VisitObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>(
            IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> objectInitializerExpression)
            where TCreateObjectExpression : ICreateObjectExpression
            where TExpression : IExpression
            where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>
        {
            Visit(objectInitializerExpression);
        }

        public virtual void VisitOutArgument<TExpression>(IOutArgument<TExpression> outArgument)
            where TExpression : IExpression
        {
            Visit(outArgument);
        }

        public virtual void VisitParenthesisExpression<TExpression>(IParenthesisExpression<TExpression> parenthesisExpression)
            where TExpression : IExpression
        {
            Visit(parenthesisExpression);
        }

        public virtual void VisitQueryJoinExpression<TExpression>(
            IQueryJoinExpression<TExpression> queryJoinExpression)
            where TExpression : IExpression
        {
            Visit(queryJoinExpression);
        }

        public virtual void VisitQueryLetExpression<TExpression>(
            IQueryLetExpression<TExpression> queryLetExpression)
            where TExpression : IExpression
        {
            Visit(queryLetExpression);
        }

        public virtual void VisitQueryOrderByExpression<TOrderingExpression>(
            IQueryOrderByExpression<TOrderingExpression> queryOrderByExpression)
            where TOrderingExpression : IQueryOrderingExpression
        {
            Visit(queryOrderByExpression);
        }

        public virtual void VisitQueryOrderingExpression<TExpression>(
            IQueryOrderingExpression<TExpression> queryOrderingExpression)
            where TExpression : IExpression
        {
            Visit(queryOrderingExpression);
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

        public virtual void VisitRawExpression(IRawExpression rawExpression)
        {
            Visit(rawExpression);
        }

        public virtual void VisitRefArgument<TExpression>(IRefArgument<TExpression> refArgument)
            where TExpression : IExpression
        {
            Visit(refArgument.Expression);
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

        public virtual void VisitAnonymousMethodParameter<TTypeReference>(
            IAnonymousMethodParameter<TTypeReference> anonymousMethodParameter)
            where TTypeReference : ITypeReference
        {
            Visit(anonymousMethodParameter);
        }

        public virtual void VisitQueryFromExpression<TExpression>(IQueryFromExpression<TExpression> queryFromExpression)
            where TExpression : IExpression
        {
            Visit(queryFromExpression);
        }

        public virtual void VisitQueryGroupExpression<TExpression>(
            IQueryGroupExpression<TExpression> queryGroupExpression)
            where TExpression : IExpression
        {
            Visit(queryGroupExpression);
        }

        public virtual void VisitQueryGroupIntoExpression<TExpression, TIdentifierExpression>(
            IQueryGroupIntoExpression<TExpression, TIdentifierExpression> queryGroupIntoExpression)
            where TExpression : IExpression
            where TIdentifierExpression : IIdentifierExpression
        {
            Visit(queryGroupIntoExpression);
        }

        public virtual void VisitQuerySelectIntoExpression<TExpression, TIdentifierExpression>(
            IQuerySelectIntoExpression<TExpression, TIdentifierExpression> querySelectIntoExpression)
            where TExpression : IExpression
            where TIdentifierExpression : IIdentifierExpression
        {
            Visit(querySelectIntoExpression);
        }

        public virtual void VisitQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>(
            IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> queryExpression)
            where TQueryFromExpression : IQueryFromExpression
            where TQueryClauseExpression : IQueryClauseExpression
            where TQueryEndExpression : IQueryEndExpression
        {
            Visit(queryExpression);
        }

        public virtual void VisitThisExpression(IThisExpression thisExpression)
        {
            Visit(thisExpression);
        }

        public virtual void VisitArgument<TExpression>(IArgument<TExpression> argument)
            where TExpression : IExpression
        {
            Visit(argument);
        }

        public virtual void VisitLambdaExpression<TExpression>(ILambdaExpression<TExpression> lambdaExpression)
            where TExpression : IExpression
        {
            Visit(lambdaExpression);
        }

        public virtual void VisitGenericMemberExpression<TExpression, TTypeReference>(
            IGenericMemberExpression<TExpression, TTypeReference> memberExpression)
            where TExpression : IExpression
            where TTypeReference : ITypeReference
        {
            Visit(memberExpression);
        }
    }
}
