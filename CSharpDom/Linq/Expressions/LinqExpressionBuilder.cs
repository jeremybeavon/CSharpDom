using System;
using System.Collections.Generic;
using System.Linq;
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
         
        public static IReadOnlyList<ILinqExpression> BuildExpressions(ElementInit initializer)
        {
            return BuildExpressions(initializer.Arguments);
        }

        public static IEnumerable<IReadOnlyList<ILinqExpression>> BuildExpressions(IEnumerable<ElementInit> initializers)
        {
            return initializers.Select(BuildExpressions);
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

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            expression = new ObjectInitializerExpressionWithLinqExpressions(node);
            return node;
        }

        protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
        {
            throw new NotSupportedException();
        }

        protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            expression = new MethodCallExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitNew(NewExpression node)
        {
            expression = new NewExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            expression = new NewArrayExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            expression = new ParameterExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitSwitch(SwitchExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override SwitchCase VisitSwitchCase(SwitchCase node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitTry(TryExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
            expression = new TypeBinaryExpressionWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            expression = new UnaryOperatorExpressionWithLinqExpressions(node);
            return node;
        }
    }
}
