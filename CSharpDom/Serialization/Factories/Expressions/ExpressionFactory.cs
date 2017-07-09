using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class ExpressionFactory : AbstractExpressionFactory<IExpression, Expression>
    {
        public ExpressionFactory(IExpression expression)
            : base(expression)
        {
        }

        public override void VisitAnonymousMethodExpression<TParameter, TStatement>(
            IAnonymousMethodExpression<TParameter, TStatement> anonymousMethod)
        {
            Value = new Expression()
            {
                AnonymousMethodExpression = new AnonymousMethodExpressionFactory(anonymousMethod).Value
            };
        }

        public override void VisitArrayIndexExpression<TExpression>(
            IArrayIndexExpression<TExpression> arrayIndexExpression)
        {
            Value = new Expression()
            {
                ArrayIndexExpression = new ArrayIndexExpressionFactory(arrayIndexExpression).Value
            };
        }

        public override void VisitAwaitExpression<TExpression>(
            IAwaitExpression<TExpression> awaitExpression)
        {
            Value = new Expression()
            {
                AwaitExpression = new AwaitExpressionFactory(awaitExpression).Value
            };
        }

        public override void VisitBinaryOperatorExpression<TExpression>(
            IBinaryOperatorExpression<TExpression> binaryOperatorExpression)
        {
            Value = new Expression()
            {
                BinaryOperatorExpression = new BinaryOperatorExpressionFactory(binaryOperatorExpression).Value
            };
        }

        public override void VisitCastExpression<TTypeReference, TExpression>(
            ICastExpression<TTypeReference, TExpression> castExpression)
        {
            Value = new Expression()
            {
                CastExpression = new CastExpressionFactory(castExpression).Value
            };
        }

        public override void VisitDefaultExpression<TTypeReference>(
            IDefaultExpression<TTypeReference> defaultExpression)
        {
            Value = new Expression()
            {
                DefaultExpression = new DefaultExpressionFactory(defaultExpression).Value
            };
        }

        public override void VisitDoubleConstantExpression(IDoubleConstantExpression doubleConstantExpression)
        {
            Value = new Expression()
            {
                DoubleConstantExpression = new DoubleConstantExpressionFactory(doubleConstantExpression).Value
            };
        }

        public override void VisitIdentifierExpression(
            IIdentifierExpression identifierExpression)
        {
            Value = new Expression()
            {
                IdentifierExpression = new IdentifierExpressionFactory(identifierExpression).Value
            };
        }

        public override void VisitIntegerConstantExpression(
            IIntegerConstantExpression integerConstantExpression)
        {
            Value = new Expression()
            {
                IntegerConstantExpression = new IntegerConstantExpressionFactory(integerConstantExpression).Value
            };
        }

        public override void VisitListInitializerExpression<TCreateListExpression, TExpression>(
            IListInitializerExpression<TCreateListExpression, TExpression> listInitializerExpression)
        {
            Value = new Expression()
            {
                ListInitializerExpression = new ListInitializerExpressionFactory(listInitializerExpression).Value
            };
        }

        public override void VisitMemberExpression<TExpression>(IMemberExpression<TExpression> memberExpression)
        {
            Value = new Expression()
            {
                MemberExpression = new MemberExpressionFactory(memberExpression).Value
            };
        }

        public override void VisitMethodCallExpression<TExpression>(
            IMethodCallExpression<TExpression> methodCallExpression)
        {
            Value = new Expression()
            {
                MethodCallExpression = new MethodCallExpressionFactory(methodCallExpression).Value
            };
        }

        public override void VisitNewAnonymousArrayExpression(INewAnonymousArrayExpression newAnonymousArrayExpression)
        {
            Value = new Expression()
            {
                NewAnonymousArrayExpression = new NewAnonymousArrayExpressionFactory(newAnonymousArrayExpression).Value
            };
        }

        public override void VisitNewAnonymousTypeExpression(INewAnonymousTypeExpression newAnonymousTypeExpression)
        {
            Value = new Expression()
            {
                NewAnonymousTypeExpression = new NewAnonymousTypeExpressionFactory(newAnonymousTypeExpression).Value
            };
        }

        public override void VisitNewArrayExpression<TTypeReference, TExpression>(
            INewArrayExpression<TTypeReference, TExpression> newArrayExpression)
        {
            Value = new Expression()
            {
                NewArrayExpression = new NewArrayExpressionFactory(newArrayExpression).Value
            };
        }

        public override void VisitNewExpression<TTypeReference, TExpression>(
            INewExpression<TTypeReference, TExpression> newExpression)
        {
            Value = new Expression()
            {
                NewExpression = new NewExpressionFactory(newExpression).Value
            };
        }

        public override void VisitNullExpression(INullExpression nullExpression)
        {
            Value = new Expression()
            {
                NullExpression = new NullExpressionFactory(nullExpression).Value
            };
        }
        
        public override void VisitOutExpression<TExpression>(IOutExpression<TExpression> outExpression)
        {
            Value = new Expression()
            {
                OutExpression = new OutExpressionFactory(outExpression).Value
            };
        }

        public override void VisitParenthesisExpression<TExpression>(
            IParenthesisExpression<TExpression> parenthesisExpression)
        {
            Value = new Expression()
            {
                ParenthesisExpression = new ParenthesisExpressionFactory(parenthesisExpression).Value
            };
        }
        
        public override void VisitRawExpression(IRawExpression rawExpression)
        {
            Value = new Expression()
            {
                RawExpression = new RawExpressionFactory(rawExpression).Value
            };
        }

        public override void VisitRefExpression<TExpression>(IRefExpression<TExpression> refExpression)
        {
            Value = new Expression()
            {
                RefExpression = new RefExpressionFactory(refExpression).Value
            };
        }

        public override void VisitStringConstantExpression(IStringConstantExpression stringConstantExpression)
        {
            Value = new Expression()
            {
                StringConstantExpression = new StringConstantExpressionFactory(stringConstantExpression).Value
            };
        }

        public override void VisitTernaryOperatorExpression<TExpression>(
            ITernaryOperatorExpression<TExpression> ternaryOperatorExpression)
        {
            Value = new Expression()
            {
                TernaryOperatorExpression = new TernaryOperatorExpressionFactory(ternaryOperatorExpression).Value
            };
        }

        public override void VisitTypeofExpression<TTypeReference>(ITypeofExpression<TTypeReference> typeofExpression)
        {
            Value = new Expression()
            {
                TypeofExpression = new TypeofExpressionFactory(typeofExpression).Value
            };
        }

        public override void VisitUnaryOperatorExpression<TExpression>(
            IUnaryOperatorExpression<TExpression> unaryOperatorExpression)
        {
            Value = new Expression()
            {
                UnaryOperatorExpression = new UnaryOperatorExpressionFactory(unaryOperatorExpression).Value
            };
        }
    }
}
