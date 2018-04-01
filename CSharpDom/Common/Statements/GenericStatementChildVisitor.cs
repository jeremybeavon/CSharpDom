using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public static class GenericStatementChildVisitor
    {
        public static void VisitBlockStatementChildren<TBlockStatement, TStatement, TVisitor>(
            TBlockStatement blockStatement,
            TVisitor visitor)
            where TBlockStatement : IBlockStatement<TStatement>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitCollection(blockStatement.Statements, visitor);
        }

        public static void VisitCatchStatementChildren<TCatchStatement, TTypeReference, TStatement, TVisitor>(
            TCatchStatement catchStatement,
            TVisitor visitor)
            where TCatchStatement : ICatchStatement<TTypeReference, TStatement>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitCollection(catchStatement.Statements, visitor);
        }

        public static void VisitDefaultCaseStatementChildren<TDefaultCaseStatement, TStatement, TVisitor>(
            TDefaultCaseStatement defaultCaseStatement,
            TVisitor visitor)
            where TDefaultCaseStatement : IDefaultCaseStatement<TStatement>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitCollection(defaultCaseStatement.Statements, visitor);
        }

        public static void VisitDoStatementChildren<TDoStatement, TExpression, TStatement, TVisitor>(
            TDoStatement doStatement,
            TVisitor visitor)
            where TDoStatement : IDoStatement<TExpression, TStatement>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitIfNotNull(doStatement.Statement, visitor);
        }

        public static void VisitFinallyStatementChildren<TFinallyStatement, TStatement, TVisitor>(
            TFinallyStatement finallyStatement,
            TVisitor visitor)
            where TFinallyStatement : IFinallyStatement<TStatement>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitCollection(finallyStatement.Statements, visitor);
        }

        public static void VisitForeachStatementChildren<TForeachStatement, TTypeReference, TExpression, TStatement, TVisitor>(
            TForeachStatement foreachStatement,
            TVisitor visitor)
            where TForeachStatement : IForeachStatement<TTypeReference, TExpression, TStatement>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitIfNotNull(foreachStatement.Statement, visitor);
        }

        public static void VisitForStatementChildren<TForStatement, TExpression, TForInitializerStatement, TStatement, TVisitor>(
            TForStatement forStatement,
            TVisitor visitor)
            where TForStatement : IForStatement<TExpression, TForInitializerStatement, TStatement>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TForInitializerStatement : IForInitializerStatement, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitIfNotNull(forStatement.InitialValueStatement, visitor);
            VisitIfNotNull(forStatement.Statement, visitor);
        }

        public static void VisitIfStatementChildren<TIfStatement, TExpression, TStatement, TVisitor>(
            TIfStatement ifStatement,
            TVisitor visitor)
            where TIfStatement : IIfStatement<TExpression, TStatement>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitIfNotNull(ifStatement.ThenStatement, visitor);
            VisitIfNotNull(ifStatement.ElseStatement, visitor);
        }

        public static void VisitLockStatementChildren<TLockStatement, TExpression, TStatement, TVisitor>(
            TLockStatement lockStatement,
            TVisitor visitor)
            where TLockStatement : ILockStatement<TExpression, TStatement>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitIfNotNull(lockStatement.Statement, visitor);
        }

        public static void VisitSwitchCaseStatementChildren<TSwitchCaseStatement, TExpression, TStatement, TVisitor>(
            TSwitchCaseStatement switchCaseStatement,
            TVisitor visitor)
            where TSwitchCaseStatement : ISwitchCaseStatement<TExpression, TStatement>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitCollection(switchCaseStatement.Statements, visitor);
        }

        public static void VisitSwitchStatementChildren<TSwitchStatement, TExpression, TSwitchCaseStatement, TDefaultCaseStatement, TVisitor>(
            TSwitchStatement switchStatement,
            TVisitor visitor)
            where TSwitchStatement : ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TSwitchCaseStatement : ISwitchCaseStatement, IVisitable<TVisitor>
            where TDefaultCaseStatement : IDefaultCaseStatement, IVisitable<TVisitor>
        {
            VisitCollection(switchStatement.Cases, visitor);
            VisitIfNotNull(switchStatement.DefaultCase, visitor);
        }

        public static void VisitTryStatementChildren<TTryStatement, TStatement, TCatchStatement, TFinallyStatement, TVisitor>(
            TTryStatement tryStatement,
            TVisitor visitor)
            where TTryStatement : ITryStatement<TStatement, TCatchStatement, TFinallyStatement>
            where TStatement : IStatement, IVisitable<TVisitor>
            where TCatchStatement : ICatchStatement, IVisitable<TVisitor>
            where TFinallyStatement : IFinallyStatement, IVisitable<TVisitor>
        {
            VisitCollection(tryStatement.TryStatements, visitor);
            VisitCollection(tryStatement.CatchStatements, visitor);
            VisitIfNotNull(tryStatement.FinallyStatement, visitor);
        }

        public static void VisitUsingStatementChildren<TUsingStatement, TExpression, TStatement, TVisitor>(
            TUsingStatement usingStatement,
            TVisitor visitor)
            where TUsingStatement : IUsingStatement<TExpression, TStatement>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitIfNotNull(usingStatement.Statement, visitor);
        }

        public static void VisitWhileStatementChildren<TWhileStatement, TExpression, TStatement, TVisitor>(
            TWhileStatement whileStatement,
            TVisitor visitor)
            where TWhileStatement : IWhileStatement<TExpression, TStatement>
            where TExpression : IExpression, IVisitable<TVisitor>
            where TStatement : IStatement, IVisitable<TVisitor>
        {
            VisitIfNotNull(whileStatement.Statement, visitor);
        }

        private static void VisitCollection<T, TVisitor>(IReadOnlyCollection<T> collection, TVisitor visitor)
            where T : IVisitable<TVisitor>
        {
            GenericChildVisitor.VisitCollection(collection, visitor);
        }

        private static void VisitIfNotNull<TVisitor>(IVisitable<TVisitor> visitable, TVisitor visitor)
        {
            GenericChildVisitor.VisitIfNotNull(visitable, visitor);
        }
    }
}