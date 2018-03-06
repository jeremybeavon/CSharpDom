using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Statements
{
    public static class StatementFactory
    {
        public static BlockStatementWithCodeAnalysis Block(IEnumerable<IStatementWithCodeAnalysis> statements)
        {
            return new BlockStatementWithCodeAnalysis(statements);
        }

        public static BreakStatementWithCodeAnalysis Break()
        {
            return new BreakStatementWithCodeAnalysis();
        }

        public static ContinueStatementWithCodeAnalysis Continue()
        {
            return new ContinueStatementWithCodeAnalysis();
        }

        public static DoStatementWithCodeAnalysis Do(
            IExpressionWithCodeAnalysis condition,
            IStatementWithCodeAnalysis statement)
        {
            return new DoStatementWithCodeAnalysis(condition, statement);
        }

        public static EmptyStatementWithCodeAnalysis Empty()
        {
            return new EmptyStatementWithCodeAnalysis();
        }

        public static ExpressionStatementWithCodeAnalysis Expression(IExpressionWithCodeAnalysis expression)
        {
            return new ExpressionStatementWithCodeAnalysis(expression);
        }

        public static ForeachStatementWithCodeAnalysis ForEach(
            ITypeReferenceWithCodeAnalysis type,
            string variableName,
            IExpressionWithCodeAnalysis iterator,
            IStatementWithCodeAnalysis statement)
        {
            return new ForeachStatementWithCodeAnalysis(type, variableName, iterator, statement);
        }

        public static GotoCaseStatementWithCodeAnalysis GotoCase(string caseName)
        {
            return new GotoCaseStatementWithCodeAnalysis(caseName);
        }

        public static IfStatementWithCodeAnalysis If(
            IExpressionWithCodeAnalysis condition,
            IStatementWithCodeAnalysis thenStatement)
        {
            return new IfStatementWithCodeAnalysis(condition, thenStatement);
        }

        public static IfStatementWithCodeAnalysis If(
            IExpressionWithCodeAnalysis condition,
            IStatementWithCodeAnalysis thenStatement,
            IStatementWithCodeAnalysis elseStatement)
        {
            return new IfStatementWithCodeAnalysis(condition, thenStatement, elseStatement);
        }

        public static LockStatementWithCodeAnalysis Lock(
            IExpressionWithCodeAnalysis expression,
            IStatementWithCodeAnalysis statement)
        {
            return new LockStatementWithCodeAnalysis(expression, statement);
        }

        public static ReturnStatementWithCodeAnalysis Return(IExpressionWithCodeAnalysis expression)
        {
            return new ReturnStatementWithCodeAnalysis(expression);
        }

        public static ThrowStatementWithCodeAnalysis Throw(IExpressionWithCodeAnalysis expression)
        {
            return new ThrowStatementWithCodeAnalysis(expression);
        }

        public static TryStatementWithCodeAnalysis Try(
            IEnumerable<IStatementWithCodeAnalysis> statements,
            IEnumerable<CatchStatementWithCodeAnalysis> catchClauses,
            FinallyStatementWithCodeAnalysis finallyClause)
        {
            return new TryStatementWithCodeAnalysis(statements, catchClauses, finallyClause);
        }

        public static UsingStatementWithCodeAnalysis Using(
            IExpressionWithCodeAnalysis expression,
            IStatementWithCodeAnalysis statement)
        {
            return new UsingStatementWithCodeAnalysis(expression, statement);
        }
    }
}
