using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;
using CSharpDom.Text.Steps;
using CSharpDom.Text.Steps.Expressions;
using CSharpDom.Text.Steps.Statements;
using System.Collections.Generic;
using WriteDefaultKeyword = CSharpDom.Text.Steps.Statements.WriteDefaultKeyword;
using WriteInKeyword = CSharpDom.Text.Steps.Statements.WriteInKeyword;

namespace CSharpDom.Text
{
    public sealed class SourceCodeStatementStepsBuilder : AbstractGenericStatementVisitor
    {
        public SourceCodeStatementStepsBuilder()
        {
            Steps = new List<ISourceCodeBuilderStep>();
        }
        
        public List<ISourceCodeBuilderStep> Steps { get; private set; }

        public override void VisitBlockStatement<TStatement>(IBlockStatement<TStatement> blockStatement)
        {
            Steps.AddBlockSteps(blockStatement.Statements);
        }

        public override void VisitBreakStatement(IBreakStatement breakStatement)
        {
            Steps.Add(new WriteBreakKeyword());
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitCatchStatement<TTypeReference, TStatement>(
            ICatchStatement<TTypeReference, TStatement> catchStatement)
        {
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteCatchKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteChildNode<TTypeReference>(catchStatement.Type));
            if (!string.IsNullOrWhiteSpace(catchStatement.VariableName))
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteName(catchStatement.VariableName));
            }

            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.AddBlockSteps(catchStatement.Statements);
        }

        public override void VisitContinueStatement(IContinueStatement continueStatement)
        {
            Steps.Add(new WriteContinueKeyword());
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitDefaultCaseStatement<TStatement>(IDefaultCaseStatement<TStatement> defaultCaseStatement)
        {
            Steps.Add(new WriteDefaultKeyword());
            Steps.Add(new WriteColon());
            Steps.AddIndentedStatementSteps(defaultCaseStatement.Statements);
        }

        public override void VisitDoStatement<TExpression, TStatement>(IDoStatement<TExpression, TStatement> doStatement)
        {
            Steps.Add(new WriteDoKeyword());
            Steps.AddIndentedStatementSteps(doStatement.Statement);
            Steps.Add(doStatement.Statement is IBlockStatement ? (ISourceCodeBuilderStep)new WriteWhitespace() : new WriteIndentedNewLine());
            Steps.Add(new WriteWhileKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteExpression<TExpression>(doStatement.Condition));
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitEmptyStatement(IEmptyStatement emptyStatement)
        {
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitExpressionStatement<TExpression>(IExpressionStatement<TExpression> expressionStatement)
        {
            Steps.Add(new WriteExpression<TExpression>(expressionStatement.Expression));
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitFinallyStatement<TStatement>(IFinallyStatement<TStatement> finallyStatement)
        {
            Steps.Add(new WriteFinallyKeyword());
            Steps.AddBlockSteps(finallyStatement.Statements);
        }

        public override void VisitForeachStatement<TTypeReference, TExpression, TStatement>(
            IForeachStatement<TTypeReference, TExpression, TStatement> foreachStatement)
        {
            Steps.Add(new WriteForeachKeyword());
            Steps.Add(new WriteWhileKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteChildNode<TTypeReference>(foreachStatement.Type));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(foreachStatement.VariableName));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteInKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(foreachStatement.Iterator));
            Steps.Add(new WriteEndParenthesis());
            Steps.AddIndentedStatementSteps(foreachStatement.Statement);
        }

        public override void VisitForStatement<TExpression, TForInitializerStatement, TStatement>(
            IForStatement<TExpression, TForInitializerStatement, TStatement> forStatement)
        {
            Steps.Add(new WriteForKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteStatement<TForInitializerStatement>(forStatement.InitialValueStatement));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(forStatement.Condition));
            Steps.Add(new WriteSemicolon());
            Steps.Add(new WriteWhitespace());
            Steps.AddCommaSeparatedExpressionSteps(forStatement.IncrementExpressions);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddIndentedStatementSteps(forStatement.Statement);
        }

        public override void VisitGotoCaseStatement(IGotoCaseStatement gotoCaseStatement)
        {
            Steps.Add(new WriteGotoKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteCaseKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteRawValue(gotoCaseStatement.CaseName));
        }

        public override void VisitGotoStatement(IGotoStatement gotoStatement)
        {
            Steps.Add(new WriteGotoKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(gotoStatement.LabelName));
        }

        public override void VisitIfStatement<TExpression, TStatement>(IIfStatement<TExpression, TStatement> ifStatement)
        {
            Steps.Add(new WriteIfKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteExpression<TExpression>(ifStatement.Condition));
            Steps.Add(new WriteEndParenthesis());
            Steps.AddIndentedStatementSteps(ifStatement.ThenStatement);
            if (ifStatement.ElseStatement != null)
            {
                Steps.Add(new WriteIndentedNewLine());
                Steps.Add(new WriteElseKeyword());
                if (ifStatement.ElseStatement is IIfStatement)
                {
                    Steps.Add(new WriteWhitespace());
                    Steps.Add(new WriteStatement<TStatement>(ifStatement.ElseStatement));
                }
                else
                {
                    Steps.AddIndentedStatementSteps(ifStatement.ElseStatement);
                }
            }
        }

        public override void VisitLabelStatement(ILabelStatement labelStatement)
        {
            Steps.Add(new WriteName(labelStatement.LabelName));
            Steps.Add(new WriteColon());
        }

        public override void VisitLockStatement<TExpression, TStatement>(ILockStatement<TExpression, TStatement> lockStatement)
        {
            Steps.Add(new WriteLockKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteExpression<TExpression>(lockStatement.Expression));
            Steps.Add(new WriteEndParenthesis());
            Steps.AddIndentedStatementSteps(lockStatement.Statement);
        }

        public override void VisitReturnStatement<TExpression>(IReturnStatement<TExpression> returnStatement)
        {
            Steps.Add(new WriteReturnKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(returnStatement.Expression));
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitSwitchCaseStatement<TExpression, TStatement>(
            ISwitchCaseStatement<TExpression, TStatement> switchCaseStatement)
        {
            bool addIndentedNewLine = false;
            foreach (TExpression match in switchCaseStatement.Matches)
            {
                Steps.AddStepIfNecessary(addIndentedNewLine, new WriteIndentedNewLine());
                addIndentedNewLine = true;
                Steps.Add(new WriteCaseKeyword());
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteExpression<TExpression>(match));
                Steps.Add(new WriteColon());
            }

            Steps.AddIndentedStatementSteps(switchCaseStatement.Statements);
        }

        public override void VisitSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>(
            ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> switchStatement)
        {
            Steps.Add(new WriteSwitchKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteExpression<TExpression>(switchStatement.Expression));
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new IncrementIndent());
            Steps.AddStatementStepsOnNewLines(switchStatement.Cases);
            if (switchStatement.DefaultCase != null)
            {
                Steps.Add(new WriteIndentedNewLine());
                Steps.Add(new WriteStatement<TDefaultCaseStatement>(switchStatement.DefaultCase));
            }
        }

        public override void VisitTryStatement<TStatement, TCatchStatement, TFinallyStatement>(
            ITryStatement<TStatement, TCatchStatement, TFinallyStatement> tryStatement)
        {
            Steps.Add(new WriteTryKeyword());
            Steps.AddBlockSteps(tryStatement.TryStatements);
            Steps.AddStatementStepsOnNewLines(tryStatement.CatchStatements);
            if (tryStatement.FinallyStatement != null)
            {
                Steps.Add(new WriteIndentedNewLine());
                Steps.Add(new WriteStatement<TFinallyStatement>(tryStatement.FinallyStatement));
            }
        }

        public override void VisitUsingStatement<TExpression, TStatement>(IUsingStatement<TExpression, TStatement> usingStatement)
        {
            Steps.Add(new WriteUsingKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteExpression<TExpression>(usingStatement.Expression));
            Steps.Add(new WriteEndParenthesis());
            Steps.AddIndentedStatementSteps(usingStatement.Statement);
        }

        public override void VisitVariableDeclarationStatement<TTypeReference, TExpression>(
            IVariableDeclarationStatement<TTypeReference, TExpression> variableDeclarationStatement)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(variableDeclarationStatement.Type));
            Steps.AddCommaSeparatedExpressionSteps(variableDeclarationStatement.Expressions);
        }

        public override void VisitWhileStatement<TExpression, TStatement>(IWhileStatement<TExpression, TStatement> whileStatement)
        {
            Steps.Add(new WriteWhileKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteExpression<TExpression>(whileStatement.Condition));
            Steps.Add(new WriteEndParenthesis());
            Steps.AddIndentedStatementSteps(whileStatement.Statement);
        }
    }
}
