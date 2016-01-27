using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public static class GenericStatementVisitor
    {
        public static void VisitBlockStatementChildren<TStatement>(
            IBlockStatement<TStatement> blockStatement,
            IGenericStatementVisitor visitor)
            where TStatement : IStatement
        {
            VisitCollection(blockStatement.Statements, visitor);
        }
        
        public static void VisitCatchStatementChildren<TTypeReference, TStatement>(
            ICatchStatement<TTypeReference, TStatement> catchStatement,
            IGenericStatementVisitor visitor)
            where TTypeReference : ITypeReference
            where TStatement : IStatement
        {
            VisitCollection(catchStatement.Statements, visitor);
        }

        public static void VisitDefaultCaseStatementChildren<TStatement>(
            IDefaultCaseStatement<TStatement> defaultCaseStatement,
            IGenericStatementVisitor visitor)
            where TStatement : IStatement
        {
            VisitCollection(defaultCaseStatement.Statements, visitor);
        }

        public static void VisitDoStatementChildren<TExpression, TStatement>(
            IDoStatement<TExpression, TStatement> doStatement,
            IGenericStatementVisitor visitor)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            VisitIfNotNull(doStatement.Statement, visitor);
        }
        
        public static void VisitFinallyStatementChildren<TStatement>(
            IFinallyStatement<TStatement> finallyStatement,
            IGenericStatementVisitor visitor)
            where TStatement : IStatement
        {
            VisitCollection(finallyStatement.Statements, visitor);
        }

        public static void VisitForeachStatementChildren<TTypeReference, TExpression, TStatement>(
            IForeachStatement<TTypeReference, TExpression, TStatement> foreachStatement,
            IGenericStatementVisitor visitor)
            where TTypeReference : ITypeReference
            where TExpression : IExpression
            where TStatement : IStatement
        {
            VisitIfNotNull(foreachStatement.Statement, visitor);
        }

        public static void VisitForStatementChildren<TExpression, TForInitializerStatement, TStatement>(
            IForStatement<TExpression, TForInitializerStatement, TStatement> forStatement,
            IGenericStatementVisitor visitor)
            where TExpression : IExpression
            where TForInitializerStatement : IForInitializerStatement
            where TStatement : IStatement
        {
            VisitIfNotNull(forStatement.InitialValueStatement, visitor);
            VisitIfNotNull(forStatement.Statement, visitor);
        }
        
        public static void VisitIfStatementChildren<TExpression, TStatement>(
            IIfStatement<TExpression, TStatement> ifStatement,
            IGenericStatementVisitor visitor)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            VisitIfNotNull(ifStatement.ThenStatement, visitor);
            VisitIfNotNull(ifStatement.ElseStatement, visitor);
        }
        
        public static void VisitLockStatementChildren<TExpression, TStatement>(
            ILockStatement<TExpression, TStatement> lockStatement,
            IGenericStatementVisitor visitor)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            VisitIfNotNull(lockStatement.Statement, visitor);
        }
        
        public static void VisitSwitchCaseStatementChildren<TExpression, TStatement>(
            ISwitchCaseStatement<TExpression, TStatement> switchCaseStatement,
            IGenericStatementVisitor visitor)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            VisitCollection(switchCaseStatement.Statements, visitor);
        }

        public static void VisitSwitchStatementChildren<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>(
            ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> switchStatement,
            IGenericStatementVisitor visitor)
            where TExpression : IExpression
            where TSwitchCaseStatement : ISwitchCaseStatement
            where TDefaultCaseStatement : IDefaultCaseStatement
        {
            VisitCollection(switchStatement.Cases, visitor);
            VisitIfNotNull(switchStatement.DefaultCase, visitor);
        }

        public static void VisitTryStatementChildren<TStatement, TCatchStatement, TFinallyStatement>(
            ITryStatement<TStatement, TCatchStatement, TFinallyStatement> tryStatement,
            IGenericStatementVisitor visitor)
            where TStatement : IStatement
            where TCatchStatement : ICatchStatement
            where TFinallyStatement : IFinallyStatement
        {
            VisitCollection(tryStatement.TryStatements, visitor);
            VisitCollection(tryStatement.CatchStatements, visitor);
            VisitIfNotNull(tryStatement.FinallyStatement, visitor);
        }

        public static void VisitUsingStatementChildren<TExpression, TStatement>(
            IUsingStatement<TExpression, TStatement> usingStatement,
            IGenericStatementVisitor visitor)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            VisitIfNotNull(usingStatement.Statement, visitor);
        }
        
        public static void VisitWhileStatementChildren<TExpression, TStatement>(
            IWhileStatement<TExpression, TStatement> whileStatement,
            IGenericStatementVisitor visitor)
            where TExpression : IExpression
            where TStatement : IStatement
        {
            VisitIfNotNull(whileStatement.Statement, visitor);
        }

        private static void VisitCollection<T>(IReadOnlyCollection<T> collection, IGenericStatementVisitor visitor)
            where T : IVisitable<IGenericStatementVisitor>
        {
            GenericVisitor.VisitCollection(collection, visitor);
        }
        
        private static void VisitIfNotNull(IVisitable<IGenericStatementVisitor> visitable, IGenericStatementVisitor visitor)
        {
            GenericVisitor.VisitIfNotNull(visitable, visitor);
        }
    }
}
