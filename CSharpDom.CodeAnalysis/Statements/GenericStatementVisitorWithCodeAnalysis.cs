using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Editable.Statements;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class GenericStatementVisitorWithCodeAnalysis : IGenericStatementVisitor
    {
        public virtual void Visit(IVisitable<IGenericStatementVisitor> node)
        {
            node.AcceptChildren(this);
        }

        public virtual void VisitBlockStatement<TStatement>(IBlockStatement<TStatement> blockStatement)
            where TStatement : IStatement
        {
            Visit(blockStatement);
        }

        public virtual void VisitBreakStatement(IBreakStatement breakStatement)
        {
            Visit(breakStatement);
        }

        public virtual void VisitCatchStatement<TTypeReference, TStatement>(
            ICatchStatement<TTypeReference, TStatement> catchStatement)
            where TTypeReference : ITypeReference
            where TStatement : IStatement
        {
            Visit(catchStatement);
        }

        public virtual void VisitContinueStatement(IContinueStatement continueStatement)
        {
            Visit(continueStatement);
        }

        public virtual void VisitDefaultCaseStatement<TStatement>(IDefaultCaseStatement<TStatement> defaultCaseStatement)
            where TStatement : IStatement
        {
            Visit(defaultCaseStatement);
        }

        public virtual void VisitDoStatement<TExpression, TStatement>(IDoStatement<TExpression, TStatement> doStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            Visit(doStatement);
        }

        public virtual void VisitEmptyStatement(IEmptyStatement emptyStatement)
        {
            Visit(emptyStatement);
        }

        public virtual void VisitExpressionStatement<TExpression>(IExpressionStatement<TExpression> expressionStatement)
            where TExpression : IExpression
        {
            Visit(expressionStatement);
        }

        public virtual void VisitFinallyStatement<TStatement>(IFinallyStatement<TStatement> finallyStatement)
            where TStatement : IStatement
        {
            Visit(finallyStatement);
        }

        public virtual void VisitForeachStatement<TTypeReference, TExpression, TStatement>(
            IForeachStatement<TTypeReference, TExpression, TStatement> foreachStatement)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
            where TStatement : IStatement
        {
            Visit(foreachStatement);
        }

        public virtual void VisitForStatement<TExpression, TForInitializerStatement, TStatement>(
            IForStatement<TExpression, TForInitializerStatement, TStatement> forStatement)
            where TExpression : IExpression
            where TForInitializerStatement : IForInitializerStatement
            where TStatement : IStatement
        {
            Visit(forStatement);
        }

        public virtual void VisitGotoCaseStatement(IGotoCaseStatement gotoCaseStatement)
        {
            Visit(gotoCaseStatement);
        }

        public virtual void VisitGotoStatement(IGotoStatement gotoStatement)
        {
            Visit(gotoStatement);
        }

        public virtual void VisitIfStatement<TExpression, TStatement>(IIfStatement<TExpression, TStatement> ifStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            Visit(ifStatement);
        }

        public virtual void VisitLabelStatement(ILabelStatement labelStatement)
        {
            Visit(labelStatement);
        }

        public virtual void VisitLockStatement<TExpression, TStatement>(ILockStatement<TExpression, TStatement> lockStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            Visit(lockStatement);
        }

        public virtual void VisitReturnStatement<TExpression>(IReturnStatement<TExpression> returnStatement)
            where TExpression : IExpression
        {
            Visit(returnStatement);
        }

        public virtual void VisitSwitchCaseStatement<TExpression, TStatement>(
            ISwitchCaseStatement<TExpression, TStatement> switchCaseStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            Visit(switchCaseStatement);
        }

        public virtual void VisitSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>(
            ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> switchStatement)
            where TExpression : IExpression
            where TSwitchCaseStatement : ISwitchCaseStatement
            where TDefaultCaseStatement : IDefaultCaseStatement
        {
            Visit(switchStatement);
        }

        public virtual void VisitTryStatement<TStatement, TCatchStatement, TFinallyStatement>(
            ITryStatement<TStatement, TCatchStatement, TFinallyStatement> tryStatement)
            where TStatement : IStatement
            where TCatchStatement : ICatchStatement
            where TFinallyStatement : IFinallyStatement
        {
            Visit(tryStatement);
        }

        public virtual void VisitUsingStatement<TExpression, TStatement>(IUsingStatement<TExpression, TStatement> usingStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            Visit(usingStatement);
        }

        public virtual void VisitVariableDeclarationStatement<TTypeReference, TExpression>(
            IVariableDeclarationStatement<TTypeReference, TExpression> variableDeclarationStatement)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
        {
            Visit(variableDeclarationStatement);
        }

        public virtual void VisitWhileStatement<TExpression, TStatement>(IWhileStatement<TExpression, TStatement> whileStatement)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            Visit(whileStatement);
        }
    }
}
