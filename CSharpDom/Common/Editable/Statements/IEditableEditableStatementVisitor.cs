using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableStatementVisitor
    {
        void Visit(IVisitable<IEditableStatementVisitor> node);

        void VisitBlockStatement<TStatement>(IEditableBlockStatement<TStatement> blockStatement)
            where TStatement : IEditableStatement;

        void VisitBreakStatement(IEditableBreakStatement breakStatement);

        void VisitCatchStatement<TTypeReference, TStatement>(IEditableCatchStatement<TTypeReference, TStatement> catchStatement)
            where TTypeReference : IEditableTypeReference
            where TStatement : IEditableStatement;

        void VisitContinueStatement(IEditableContinueStatement continueStatement);

        void VisitDefaultCaseStatement<TStatement>(IEditableDefaultCaseStatement<TStatement> defaultCaseStatement)
            where TStatement : IEditableStatement;

        void VisitDoStatement<TExpression, TStatement>(IEditableDoStatement<TExpression, TStatement> doStatement)
            where TExpression : IEditableExpression
            where TStatement : IEditableStatement;

        void VisitEmptyStatement(IEditableEmptyStatement emptyStatement);

        void VisitExpressionStatement<TExpression>(IEditableExpressionStatement<TExpression> expressionStatement)
            where TExpression : IEditableExpression;

        void VisitFinallyStatement<TStatement>(IEditableFinallyStatement<TStatement> finallyStatement)
            where TStatement : IEditableStatement;

        void VisitForeachStatement<TTypeReference, TExpression, TStatement>(
            IEditableForeachStatement<TTypeReference, TExpression, TStatement> foreachStatement)
            where TTypeReference : IEditableTypeReference
            where TExpression : IEditableExpression
            where TStatement : IEditableStatement;

        void VisitForStatement<TExpression, TForInitializerStatement, TStatement>(
            IEditableForStatement<TExpression, TForInitializerStatement, TStatement> forStatement)
            where TExpression : IEditableExpression
            where TForInitializerStatement : IEditableForInitializerStatement
            where TStatement : IEditableStatement;

        void VisitGotoCaseStatement(IEditableGotoCaseStatement gotoCaseStatement);

        void VisitGotoStatement(IEditableGotoStatement gotoStatement);

        void VisitIfStatement<TExpression, TStatement>(IEditableIfStatement<TExpression, TStatement> ifStatement)
            where TExpression : IEditableExpression
            where TStatement : IEditableStatement;

        void VisitLabelStatement(IEditableLabelStatement labelStatement);

        void VisitLockStatement<TExpression, TStatement>(IEditableLockStatement<TExpression, TStatement> lockStatement)
            where TExpression : IEditableExpression
            where TStatement : IEditableStatement;

        void VisitReturnStatement<TExpression>(IEditableReturnStatement<TExpression> returnStatement)
            where TExpression : IEditableExpression;

        void VisitSwitchCaseStatement<TExpression, TStatement>(
            IEditableSwitchCaseStatement<TExpression, TStatement> switchCaseStatement)
            where TExpression : IEditableExpression
            where TStatement : IEditableStatement;

        void VisitSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>(
            IEditableSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> switchStatement)
            where TExpression : IEditableExpression
            where TSwitchCaseStatement : IEditableSwitchCaseStatement
            where TDefaultCaseStatement : IEditableDefaultCaseStatement;

        void VisitTryStatement<TStatement, TCatchStatement, TFinallyStatement>(
            IEditableTryStatement<TStatement, TCatchStatement, TFinallyStatement> tryStatement)
            where TStatement : IEditableStatement
            where TCatchStatement : IEditableCatchStatement
            where TFinallyStatement : IEditableFinallyStatement;

        void VisitUsingStatement<TExpression, TStatement>(IEditableUsingStatement<TExpression, TStatement> usingStatement)
            where TExpression : IEditableExpression
            where TStatement : IEditableStatement;

        void VisitVariableDeclarationStatement<TTypeReference, TExpression>(
            IEditableVariableDeclarationStatement<TTypeReference, TExpression> variableDeclarationStatement)
            where TTypeReference : IEditableTypeReference
            where TExpression : IEditableExpression;

        void VisitWhileStatement<TExpression, TStatement>(IEditableWhileStatement<TExpression, TStatement> whileStatement)
            where TExpression : IEditableExpression
            where TStatement : IEditableStatement;
    }
}