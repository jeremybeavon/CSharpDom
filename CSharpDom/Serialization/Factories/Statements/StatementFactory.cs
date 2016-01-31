using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class StatementFactory : AbstractStatementFactory<IStatement, Statement>
    {
        public StatementFactory(IStatement statement)
            : base(statement)
        {
        }

        public override void VisitBlockStatement<TStatement>(IBlockStatement<TStatement> blockStatement)
        {
            Value = new Statement()
            {
                BlockStatement = new BlockStatementFactory(blockStatement).Value
            };
        }

        public override void VisitBreakStatement(IBreakStatement breakStatement)
        {
            Value = new Statement()
            {
                BreakStatement = new BreakStatementFactory(breakStatement).Value
            };
        }

        public override void VisitContinueStatement(IContinueStatement continueStatement)
        {
            Value = new Statement()
            {
                ContinueStatement = new ContinueStatementFactory(continueStatement).Value
            };
        }

        public override void VisitDoStatement<TExpression, TStatement>(IDoStatement<TExpression, TStatement> doStatement)
        {
            Value = new Statement()
            {
                DoStatement = new DoStatementFactory(doStatement).Value
            };
        }

        public override void VisitEmptyStatement(IEmptyStatement emptyStatement)
        {
            Value = new Statement()
            {
                EmptyStatement = new EmptyStatementFactory(emptyStatement).Value
            };
        }

        public override void VisitExpressionStatement<TExpression>(IExpressionStatement<TExpression> expressionStatement)
        {
            Value = new Statement()
            {
                ExpressionStatement = new ExpressionStatementFactory(expressionStatement).Value
            };
        }

        public override void VisitForeachStatement<TTypeReference, TExpression, TStatement>(IForeachStatement<TTypeReference, TExpression, TStatement> foreachStatement)
        {
            Value = new Statement()
            {
                ForeachStatement = new ForeachStatementFactory(foreachStatement).Value
            };
        }

        public override void VisitForStatement<TExpression, TForInitializerStatement, TStatement>(IForStatement<TExpression, TForInitializerStatement, TStatement> forStatement)
        {
            Value = new Statement()
            {
                ForStatement = new ForStatementFactory(forStatement).Value
            };
        }

        public override void VisitGotoCaseStatement(IGotoCaseStatement gotoCaseStatement)
        {
            Value = new Statement()
            {
                GotoCaseStatement = new GotoCaseStatementFactory(gotoCaseStatement).Value
            };
        }

        public override void VisitGotoStatement(IGotoStatement gotoStatement)
        {
            Value = new Statement()
            {
                GotoStatement = new GotoStatementFactory(gotoStatement).Value
            };
        }

        public override void VisitIfStatement<TExpression, TStatement>(IIfStatement<TExpression, TStatement> ifStatement)
        {
            Value = new Statement()
            {
                IfStatement = new IfStatementFactory(ifStatement).Value
            };
        }

        public override void VisitLabelStatement(ILabelStatement labelStatement)
        {
            Value = new Statement()
            {
                LabelStatement = new LabelStatementFactory(labelStatement).Value
            };
        }

        public override void VisitLockStatement<TExpression, TStatement>(ILockStatement<TExpression, TStatement> lockStatement)
        {
            Value = new Statement()
            {
                LockStatement = new LockStatementFactory(lockStatement).Value
            };
        }

        public override void VisitReturnStatement<TExpression>(IReturnStatement<TExpression> returnStatement)
        {
            Value = new Statement()
            {
                ReturnStatement = new ReturnStatementFactory(returnStatement).Value
            };
        }

        public override void VisitSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>(ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> switchStatement)
        {
            Value = new Statement()
            {
                SwitchStatement = new SwitchStatementFactory(switchStatement).Value
            };
        }

        public override void VisitTryStatement<TStatement, TCatchStatement, TFinallyStatement>(ITryStatement<TStatement, TCatchStatement, TFinallyStatement> tryStatement)
        {
            Value = new Statement()
            {
                TryStatement = new TryStatementFactory(tryStatement).Value
            };
        }

        public override void VisitUsingStatement<TExpression, TStatement>(IUsingStatement<TExpression, TStatement> usingStatement)
        {
            Value = new Statement()
            {
                UsingStatement = new UsingStatementFactory(usingStatement).Value
            };
        }

        public override void VisitVariableDeclarationStatement<TTypeReference, TExpression>(
            IVariableDeclarationStatement<TTypeReference, TExpression> variableDeclarationStatement)
        {
            Value = new Statement()
            {
                VariableDeclarationStatement = new VariableDeclarationStatementFactory(variableDeclarationStatement).Value
            };
        }

        public override void VisitWhileStatement<TExpression, TStatement>(IWhileStatement<TExpression, TStatement> whileStatement)
        {
            Value = new Statement()
            {
                WhileStatement = new WhileStatementFactory(whileStatement).Value
            };
        }
    }
}
