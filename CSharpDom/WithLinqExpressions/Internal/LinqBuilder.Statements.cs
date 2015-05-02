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
            localVariables.StartBlock();
            IReadOnlyList<ILinqExpressionMapping> statements =
                node.Statements.Select(statement => statement.Accept(this)).ToArray();
            IEnumerable<Expression> expressions = statements.SelectMany(statement => statement.Expressions);
            BlockExpression expression = Expression.Block(localVariables.CurrentLocalVariables, expressions);
            localVariables.EndBlock();
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
            LabelTarget previousBreakTarget = breakTarget;
            LabelTarget previousContinueTarget = continueTarget;
            breakTarget = Expression.Label();
            continueTarget = Expression.Label();
            ILinqExpressionMapping condition = node.Condition.Accept(this);
            ILinqExpressionMapping statement = node.Statement.Accept(this);
            Expression exit = Expression.IfThen(Expression.Not(condition.Expressions.Single()), Expression.Break(breakTarget));
            LoopExpression loop = Expression.Loop(Expression.Block(statement.Expressions.Single(), exit), breakTarget, continueTarget);
            breakTarget = previousBreakTarget;
            continueTarget = previousContinueTarget;
            return new DoStatement(loop, node)
            {
                Condition = condition,
                Statement = statement
            };
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
            localVariables.StartBlock();
            IEnumerable<ILinqExpressionMapping> initializers = node.Initializers.Accept(this);
            ILinqExpressionMapping condition = node.Condition.Accept(this);
            IEnumerable<ILinqExpressionMapping> incrementors = node.Incrementors.Accept(this);
            ILinqExpressionMapping statement = node.Statement.Accept(this);
            Expression exit = Expression.IfThen(Expression.Not(condition.Expressions.Single()), Expression.Break(breakTarget));
            Expression loop = Expression.Loop(Expression.Block(exit, statement.Expressions.Single()), breakTarget, continueTarget);
            IEnumerable<Expression> expressions = initializers.SelectMany(initializer => initializer.Expressions).Concat(new[] { loop });
            BlockExpression forLoop = Expression.Block(localVariables.CurrentLocalVariables, expressions);
            localVariables.EndBlock();
            breakTarget = previousBreakTarget;
            continueTarget = previousContinueTarget;
            return new ForStatement(forLoop, node)
            {
                Initializers = initializers,
                Condition = condition,
                Incrementors = incrementors,
                Statement = statement
            };
        }

        public override ILinqExpressionMapping VisitForEachStatement(ForEachStatementSyntax node)
        {
            return base.VisitForEachStatement(node);
        }

        public override ILinqExpressionMapping VisitGotoStatement(GotoStatementSyntax node)
        {
            string labelName = ((IdentifierNameSyntax)node.Expression).Identifier.Text;
            return new GotoStatement(Expression.Goto(labelTargets.GetLabelTarget(labelName)), node);
        }

        public override ILinqExpressionMapping VisitIfStatement(IfStatementSyntax node)
        {
            ILinqExpressionMapping condition = node.Condition.Accept(this);
            ILinqExpressionMapping whenTrue = node.Statement.Accept(this);
            ILinqExpressionMapping whenFalse = node.Else == null ? null : node.Else.Accept(this);
            ConditionalExpression expression = node.Else == null ?
                Expression.IfThen(condition.Expressions.Single(), whenTrue.Expressions.Single()) :
                Expression.IfThenElse(condition.Expressions.Single(), whenTrue.Expressions.Single(), whenFalse.Expressions.Single());
            return new IfStatement(expression, node)
            {
                Condition = condition,
                TrueImplementation = whenTrue,
                FalseImplementation = whenFalse
            };
        }

        public override ILinqExpressionMapping VisitLabeledStatement(LabeledStatementSyntax node)
        {
            LabelExpression label = Expression.Label(labelTargets.GetLabelTarget(node.Identifier.Text));
            ILinqExpressionMapping statement = node.Statement.Accept(this);
            return new LabelStatement(label, statement, node);
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
            return new ReturnStatement(node.Expression.Accept(this), node);
        }

        public override ILinqExpressionMapping VisitSwitchStatement(SwitchStatementSyntax node)
        {
            return base.VisitSwitchStatement(node);
        }

        public override ILinqExpressionMapping VisitThrowStatement(ThrowStatementSyntax node)
        {
            ILinqExpressionMapping expression = node.Expression.Accept(this);
            return new ThrowStatement(Expression.Throw(expression.Expressions.Single()), node)
            {
                ThrowExpression = expression
            };
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
            LabelTarget previousBreakTarget = breakTarget;
            LabelTarget previousContinueTarget = continueTarget;
            breakTarget = Expression.Label();
            continueTarget = Expression.Label();
            ILinqExpressionMapping condition = node.Condition.Accept(this);
            ILinqExpressionMapping statement = node.Statement.Accept(this);
            Expression exit = Expression.IfThen(Expression.Not(condition.Expressions.Single()), Expression.Break(breakTarget));
            LoopExpression loop = Expression.Loop(Expression.Block(exit, statement.Expressions.Single()), breakTarget, continueTarget);
            breakTarget = previousBreakTarget;
            continueTarget = previousContinueTarget;
            return new WhileStatement(loop, node)
            {
                Condition = condition,
                Statement = statement
            };
        }

        public override ILinqExpressionMapping VisitYieldStatement(YieldStatementSyntax node)
        {
            return base.VisitYieldStatement(node);
        }
    }
}
