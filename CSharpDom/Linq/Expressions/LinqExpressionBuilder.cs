using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class LinqExpressionBuilder : ExpressionVisitor
    {
        public ILinqExpression expression;

        private LinqExpressionBuilder()
        {
        }

        public static ILinqExpression BuildExpression(Expression expression)
        {
            LinqExpressionBuilder expressionBuilder = new LinqExpressionBuilder();
            expressionBuilder.Visit(expression);
            return expressionBuilder.expression;
        }

        public static IReadOnlyList<ILinqExpression> BuildExpressions(IEnumerable<Expression> expressions)
        {
            return expressions.ToArray(BuildExpression);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            expression = new BinaryOperatorExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            expression = new TernaryOperatorExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node.Value == null)
            {
                expression = new NullExpressionWithLinqExpressions(node);
            }
            else if (node.Value is int)
            {
                expression = new IntegerConstantWithLinqExpressions(node);
            }
            else if (node.Value is double)
            {
                expression = new DoubleConstantWithLinqExpressions(node);
            }
            else if (node.Value is string)
            {
                expression = new StringConstantWithLinqExpressions(node);
            }
            else
            {
                throw new NotImplementedException();
            }

            return node;
        }

        protected override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitDefault(DefaultExpression node)
        {
            expression = new DefaultExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitDynamic(DynamicExpression node)
        {
            expression = new DynamicMethodCallExpressionWithLinqExpressions(node);
            return base.VisitDynamic(node);
        }

        protected override ElementInit VisitElementInit(ElementInit node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitExtension(Expression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitGoto(GotoExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            expression = new ArrayIndexExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            expression = new DelegateMethodCallExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitLabel(LabelExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override LabelTarget VisitLabelTarget(LabelTarget node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            expression = new AnonymousMethodExpressionWithLinqExpressions<T>(node);
            return node;
        }

        protected override Expression VisitListInit(ListInitExpression node)
        {
            expression = new ListInitializerExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitLoop(LoopExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            expression = new MemberExpressionWithLinqExpressions(node);
            return node;
        }

        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            throw new InvalidOperationException();
        }

        protected override MemberBinding VisitMemberBinding(MemberBinding node)
        {
            throw new InvalidOperationException();
        }
    }
}
