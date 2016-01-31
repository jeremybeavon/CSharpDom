using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class LinqStatementBuilder : ExpressionVisitor
    {
        public ILinqStatement statement;

        private LinqStatementBuilder()
        {
        }

        public static ILinqStatement BuildStatement(Expression statement)
        {
            LinqStatementBuilder statementBuilder = new LinqStatementBuilder();
            statementBuilder.Visit(statement);
            return statementBuilder.statement;
        }

        public static IReadOnlyList<ILinqStatement> BuildStatements(IEnumerable<Expression> statements)
        {
            return statements.ToArray(BuildStatement);
        }

        public static IReadOnlyList<ILinqStatement> BuildStatements(Expression statement)
        {
            BlockExpression block = statement as BlockExpression;
            return block == null ? new ILinqStatement[] { BuildStatement(statement) } : BuildStatements(block.Expressions);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            statement = new BlockStatementWithLinqExpressions(node);
            return node;
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitDefault(DefaultExpression node)
        {
            statement = new EmptyStatementWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitDynamic(DynamicExpression node)
        {
            throw new InvalidOperationException();
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
            switch (node.Kind)
            {
                case GotoExpressionKind.Break:
                    statement = new BreakStatementWithLinqExpressions(node);
                    break;
                case GotoExpressionKind.Continue:
                    statement = new ContinueStatementWithLinqExpressions(node);
                    break;
                case GotoExpressionKind.Goto:
                    statement = new GotoStatementWithLinqExpressions(node);
                    break;
                case GotoExpressionKind.Return:
                    statement = new ReturnStatementWithLinqExpressions(node);
                    break;
            }

            return node;
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitLabel(LabelExpression node)
        {
            statement = new LabelStatementWithLinqExpressions(node);
            return node;
        }

        protected override LabelTarget VisitLabelTarget(LabelTarget node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitListInit(ListInitExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitLoop(LoopExpression node)
        {
            statement = new ForStatementWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            throw new NotSupportedException();
        }

        protected override MemberBinding VisitMemberBinding(MemberBinding node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            throw new InvalidOperationException();
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
            throw new InvalidOperationException();
        }

        protected override Expression VisitNew(NewExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitSwitch(SwitchExpression node)
        {
            statement = new SwitchStatementWithLinqExpressions(node);
            return node;
        }

        protected override SwitchCase VisitSwitchCase(SwitchCase node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitTry(TryExpression node)
        {
            statement = new TryStatementWithLinqExpressions(node);
            return node;
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
            throw new InvalidOperationException();
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            throw new InvalidOperationException();
        }
    }
}
