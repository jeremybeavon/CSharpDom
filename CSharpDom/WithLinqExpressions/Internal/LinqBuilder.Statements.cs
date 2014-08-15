using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed partial class LinqBuilder
    {
        private LabelTarget breakTarget;
        private LabelTarget continueTarget;

        public override ILinqExpressionMapping VisitBlock(BlockSyntax node)
        {
            IReadOnlyList<ILinqExpressionMapping> statements =
                node.Statements.Select(statement => statement.Accept(this)).ToArray();
            BlockExpression expression = Expression.Block(statements.Select(statement => statement.Expression));
            return new BlockStatement(expression, node, statements);
        }

        public override ILinqExpressionMapping VisitBreakStatement(BreakStatementSyntax node)
        {
            return new BreakStatement(Expression.Break(breakTarget), node);
        }

        public override ILinqExpressionMapping VisitContinueStatement(ContinueStatementSyntax node)
        {
            return new ContinueStatement(Expression.Continue(continueTarget), node);
        }

        public override ILinqExpressionMapping VisitEmptyStatement(EmptyStatementSyntax node)
        {
            return new EmptyStatement(Expression.Empty(), node);
        }

        public override ILinqExpressionMapping VisitDoStatement(DoStatementSyntax node)
        {
            return base.VisitDoStatement(node);
        }

        public override ILinqExpressionMapping VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            return node.Expression.Accept(this);
        }

        public override ILinqExpressionMapping VisitForStatement(ForStatementSyntax node)
        {
            LabelTarget previousBreakTarget = breakTarget;
            LabelTarget previousContinueTarget = continueTarget;
            breakTarget = Expression.Label();
            continueTarget = Expression.Label();
            ILinqExpressionMapping initializers = node.Initializers.Accept(this);
            ILinqExpressionMapping condition = node.Condition.Accept(this);
            ILinqExpressionMapping incrementors = node.Incrementors.Accept(this);
            ILinqExpressionMapping statement = node.Statement.Accept(this);
            
            breakTarget = previousBreakTarget;
            continueTarget = previousContinueTarget;
            return base.VisitForStatement(node);
        }

        public override ILinqExpressionMapping VisitForEachStatement(ForEachStatementSyntax node)
        {
            return base.VisitForEachStatement(node);
        }

        public override ILinqExpressionMapping VisitGotoStatement(GotoStatementSyntax node)
        {
            return base.VisitGotoStatement(node);
        }

        public override ILinqExpressionMapping VisitIfStatement(IfStatementSyntax node)
        {
            ILinqExpressionMapping condition = node.Condition.Accept(this);
            ILinqExpressionMapping whenTrue = node.Statement.Accept(this);
            ILinqExpressionMapping whenFalse = node.Else == null ? null : node.Else.Accept(this);
            ConditionalExpression expression = node.Else == null ?
                Expression.IfThen(condition.Expression, whenTrue.Expression) :
                Expression.IfThenElse(condition.Expression, whenTrue.Expression, whenFalse.Expression);
            return new IfStatement(expression, node)
            {
                Condition = condition,
                TrueImplementation = whenTrue,
                FalseImplementation = whenFalse
            };
        }

        public override ILinqExpressionMapping VisitLabeledStatement(LabeledStatementSyntax node)
        {
            return base.VisitLabeledStatement(node);
        }

        public override ILinqExpressionMapping VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        {
            return base.VisitLocalDeclarationStatement(node);
        }

        public override ILinqExpressionMapping VisitLockStatement(LockStatementSyntax node)
        {
            return base.VisitLockStatement(node);
        }

        public override ILinqExpressionMapping VisitReturnStatement(ReturnStatementSyntax node)
        {
            node.Expression.Accept(this);
            return base.VisitReturnStatement(node);
        }

        public override ILinqExpressionMapping VisitSwitchStatement(SwitchStatementSyntax node)
        {
            return base.VisitSwitchStatement(node);
        }

        public override ILinqExpressionMapping VisitThrowStatement(ThrowStatementSyntax node)
        {
            return base.VisitThrowStatement(node);
        }

        public override ILinqExpressionMapping VisitTryStatement(TryStatementSyntax node)
        {
            return base.VisitTryStatement(node);
        }

        public override ILinqExpressionMapping VisitUsingStatement(UsingStatementSyntax node)
        {
            return base.VisitUsingStatement(node);
        }

        public override ILinqExpressionMapping VisitWhileStatement(WhileStatementSyntax node)
        {
            return base.VisitWhileStatement(node);
        }

        public override ILinqExpressionMapping VisitYieldStatement(YieldStatementSyntax node)
        {
            return base.VisitYieldStatement(node);
        }
    }
}
