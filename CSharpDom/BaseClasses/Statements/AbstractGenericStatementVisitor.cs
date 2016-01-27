using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractGenericStatementVisitor : IGenericStatementVisitor
    {
        public virtual void VisitBlockStatement<TStatement>(IBlockStatement<TStatement> blockStatement)
            where TStatement : IStatement
        {
            blockStatement.AcceptChildren(this);
        }

        public virtual void VisitBreakStatement(IBreakStatement breakStatement)
        {
            breakStatement.AcceptChildren(this);
        }

        public virtual void VisitCatchStatement<TTypeReference, TStatement>(
            ICatchStatement<TTypeReference, TStatement> catchStatement)
            where TTypeReference : ITypeReference
            where TStatement : IStatement
        {
            catchStatement.AcceptChildren(this);
        }

        public virtual void VisitContinueStatement(IContinueStatement continueStatement)
        {
            continueStatement.AcceptChildren(this);
        }

        public virtual void VisitDefaultCaseStatement<TStatement>(IDefaultCaseStatement<TStatement> defaultCaseStatement)
            where TStatement : IStatement
        {
            defaultCaseStatement.AcceptChildren(this);
        }

        public virtual void VisitDoStatement<TExpression, TStatement>(IDoStatement<TExpression, TStatement> doStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            doStatement.AcceptChildren(this);
        }

        public virtual void VisitEmptyStatement(IEmptyStatement emptyStatement)
        {
            emptyStatement.AcceptChildren(this);
        }

        public virtual void VisitExpressionStatement<TExpression>(IExpressionStatement<TExpression> expressionStatement)
            where TExpression : IExpression
        {
            expressionStatement.AcceptChildren(this);
        }

        public virtual void VisitFinallyStatement<TStatement>(IFinallyStatement<TStatement> finallyStatement)
            where TStatement : IStatement
        {
            finallyStatement.AcceptChildren(this);
        }

        public virtual void VisitForeachStatement<TTypeReference, TExpression, TStatement>(
            IForeachStatement<TTypeReference, TExpression, TStatement> foreachStatement)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
            where TStatement : IStatement
        {
            foreachStatement.AcceptChildren(this);
        }

        public virtual void VisitForStatement<TExpression, TForInitializerStatement, TStatement>(
            IForStatement<TExpression, TForInitializerStatement, TStatement> forStatement)
            where TExpression : IExpression
            where TForInitializerStatement : IForInitializerStatement
            where TStatement : IStatement
        {
            forStatement.AcceptChildren(this);
        }

        public virtual void VisitGotoCaseStatement(IGotoCaseStatement gotoCaseStatement)
        {
            gotoCaseStatement.AcceptChildren(this);
        }

        public virtual void VisitGotoStatement(IGotoStatement gotoStatement)
        {
            gotoStatement.AcceptChildren(this);
        }

        public virtual void VisitIfStatement<TExpression, TStatement>(IIfStatement<TExpression, TStatement> ifStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            ifStatement.AcceptChildren(this);
        }

        public virtual void VisitLabelStatement(ILabelStatement labelStatement)
        {
            labelStatement.AcceptChildren(this);
        }

        public virtual void VisitLockStatement<TExpression, TStatement>(ILockStatement<TExpression, TStatement> lockStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            lockStatement.AcceptChildren(this);
        }

        public virtual void VisitReturnStatement<TExpression>(IReturnStatement<TExpression> returnStatement)
            where TExpression : IExpression
        {
            returnStatement.AcceptChildren(this);
        }

        public virtual void VisitSwitchCaseStatement<TExpression, TStatement>(
            ISwitchCaseStatement<TExpression, TStatement> switchCaseStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            switchCaseStatement.AcceptChildren(this);
        }

        public virtual void VisitSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>(
            ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> switchStatement)
            where TExpression : IExpression
            where TSwitchCaseStatement : ISwitchCaseStatement
            where TDefaultCaseStatement : IDefaultCaseStatement
        {
            switchStatement.AcceptChildren(this);
        }

        public virtual void VisitTryStatement<TStatement, TCatchStatement, TFinallyStatement>(
            ITryStatement<TStatement, TCatchStatement, TFinallyStatement> tryStatement)
            where TStatement : IStatement
            where TCatchStatement : ICatchStatement
            where TFinallyStatement : IFinallyStatement
        {
            tryStatement.AcceptChildren(this);
        }

        public virtual void VisitUsingStatement<TExpression, TStatement>(IUsingStatement<TExpression, TStatement> usingStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            usingStatement.AcceptChildren(this);
        }

        public virtual void VisitVariableDeclarationStatement<TTypeReference, TExpression>(
            IVariableDeclarationStatement<TTypeReference, TExpression> variableDeclarationStatement)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            variableDeclarationStatement.AcceptChildren(this);
        }

        public virtual void VisitWhileStatement<TExpression, TStatement>(IWhileStatement<TExpression, TStatement> whileStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            whileStatement.AcceptChildren(this);
        }
    }
}
