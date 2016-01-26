using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IGenericStatementVisitor
    {
        void VisitBlockStatement<TStatement>(IBlockStatement<TStatement> blockStatement)
            where TStatement : IStatement;

        void VisitBreakStatement(IBreakStatement breakStatement);

        void VisitCatchStatement<TTypeReference, TStatement>(ICatchStatement<TTypeReference, TStatement> catchStatement)
            where TTypeReference : ITypeReference
            where TStatement : IStatement;

        void VisitContinueStatement(IContinueStatement continueStatement);

        void VisitDoStatement<TExpression, TStatement>(IDoStatement<TExpression, TStatement> doStatement)
            where TExpression : IExpression
            where TStatement : IStatement;

        void VisitEmptyStatement(IEmptyStatement emptyStatement);

        void VisitExpressionStatement<TExpression>(IExpressionStatement<TExpression> expressionStatement)
            where TExpression : IExpression;

        void VisitFinallyStatement<TStatement>(IFinallyStatement<TStatement> finallyStatement)
            where TStatement : IStatement;

        void VisitForeachStatement<TTypeReference, TExpression, TStatement>(
            IForeachStatement<TTypeReference, TExpression, TStatement> foreachStatement)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
            where TStatement : IStatement;

        void VisitForStatement<TExpression, TForInitializerStatement, TStatement>(
            IForStatement<TExpression, TForInitializerStatement, TStatement> forStatement)
            where TExpression : IExpression
            where TForInitializerStatement : IForInitializerStatement
            where TStatement : IStatement;

        void VisitGotoCaseStatement(IGotoCaseStatement gotoCaseStatement);

        void VisitGotoStatement(IGotoStatement gotoStatement);

        void VisitIfStatement<TExpression, TStatement>(IIfStatement<TExpression, TStatement> ifStatement)
            where TExpression : IExpression
            where TStatement : IStatement;

        void VisitLabelStatement(ILabelStatement labelStatement);

        void VisitLockStatement<TExpression, TStatement>(ILockStatement<TExpression, TStatement> lockStatement)
            where TExpression : IExpression
            where TStatement : IStatement;

        void VisitReturnStatement<TExpression>(IReturnStatement<TExpression> returnStatement)
            where TExpression : IExpression;

        void VisitSwitchCaseStatement<TExpression, TStatement>(ISwitchCaseStatement<TExpression, TStatement> switchCaseStatement)
            where TExpression : IExpression
            where TStatement : IStatement;

        void VisitSwitchStatement<TExpression, TSwitchCaseStatement, TStatement>(
            ISwitchStatement<TExpression, TSwitchCaseStatement, TStatement> switchStatement)
            where TExpression : IExpression
            where TSwitchCaseStatement : ISwitchCaseStatement
            where TStatement : IStatement;

        void VisitTryStatement<TStatement, TCatchStatement, TFinallyStatement>(
            ITryStatement<TStatement, TCatchStatement, TFinallyStatement> tryStatement)
            where TStatement : IStatement
            where TCatchStatement : ICatchStatement
            where TFinallyStatement : IFinallyStatement;

        void VisitUsingStatement<TExpression, TStatement>(IUsingStatement<TExpression, TStatement> usingStatement)
            where TExpression : IExpression
            where TStatement : IStatement;

        void VisitVariableDeclarationStatement<TTypeReference, TExpression>(
            IVariableDeclarationStatement<TTypeReference, TExpression> variableDeclarationStatement)
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitWhileStatement<TExpression, TStatement>(IWhileStatement<TExpression, TStatement> whileStatement)
            where TExpression : IExpression
            where TStatement : IStatement;
    }
}
