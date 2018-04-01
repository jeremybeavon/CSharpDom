using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using CSharpDom.Text.Steps;
using CSharpDom.Text.Steps.Expressions;
using System;
using System.Collections.Generic;

namespace CSharpDom.Text
{
    public sealed class SourceCodeExpressionStepsBuilder : AbstractGenericExpressionVisitor, IHasSourceSourceBuilderSteps
    {
        public SourceCodeExpressionStepsBuilder()
        {
            Steps = new List<ISourceCodeBuilderStep>();
        }

        public List<ISourceCodeBuilderStep> Steps { get; private set; }

        public override void Visit(IVisitable<IGenericExpressionVisitor> node)
        {
            throw new InvalidOperationException();
        }

        public override void VisitArgument<TExpression>(IArgument<TExpression> argument)
        {
            if (!string.IsNullOrWhiteSpace(argument.Name))
            {
                Steps.Add(new WriteName(argument.Name));
                Steps.Add(new WriteColon());
                Steps.Add(new WriteWhitespace());
            }

            Steps.Add(new WriteExpression<TExpression>(argument.Expression));
        }

        public override void VisitArrayIndexExpression<TExpression, TArgument>(
            IArrayIndexExpression<TExpression, TArgument> arrayIndexExpression)
        {
            Steps.Add(new WriteExpression<TExpression>(arrayIndexExpression.Array));
            Steps.Add(new WriteStartBracket());
            Steps.AddCommaSeparatedExpressionSteps(arrayIndexExpression.Indexes);
            Steps.Add(new WriteEndBracket());
        }

        public override void VisitAwaitExpression<TExpression>(IAwaitExpression<TExpression> awaitExpression)
        {
            Steps.Add(new WriteAwaitKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(awaitExpression.Expression));
        }

        public override void VisitBinaryOperatorExpression<TExpression>(
            IBinaryOperatorExpression<TExpression> binaryOperatorExpression)
        {
            Steps.Add(new WriteExpression<TExpression>(binaryOperatorExpression.Left));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteBinaryOperatorExpressionType(binaryOperatorExpression.OperatorType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(binaryOperatorExpression.Right));
        }

        public override void VisitCastExpression<TTypeReference, TExpression>(
            ICastExpression<TTypeReference, TExpression> castExpression)
        {
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteChildNode<TTypeReference>(castExpression.Type));
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteExpression<TExpression>(castExpression.Expression));
        }

        public override void VisitDefaultExpression<TTypeReference>(IDefaultExpression<TTypeReference> defaultExpression)
        {
            Steps.Add(new WriteDefaultKeyword());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteChildNode<TTypeReference>(defaultExpression.Type));
            Steps.Add(new WriteEndParenthesis());
        }

        public override void VisitDoubleConstantExpression(IDoubleConstantExpression doubleConstantExpression)
        {
            Steps.Add(new WriteDoubleConstant(doubleConstantExpression.Constant));
        }

        public override void VisitIdentifierExpression(IIdentifierExpression identifierExpression)
        {
            Steps.Add(new WriteName(identifierExpression.Name));
        }

        public override void VisitIntegerConstantExpression(IIntegerConstantExpression integerConstantExpression)
        {
            Steps.Add(new WriteIntegerConstant(integerConstantExpression.Constant));
        }

        public override void VisitListInitializerExpression<TCreateListExpression, TExpression>(
            IListInitializerExpression<TCreateListExpression, TExpression> listInitializerExpression)
        {
            Steps.Add(new WriteExpression<TCreateListExpression>(listInitializerExpression.CreateListExpression));
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.AddListInitializerSteps(listInitializerExpression.InitialValues);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitMemberExpression<TExpression>(IMemberExpression<TExpression> memberExpression)
        {
            Steps.Add(new WriteExpression<TExpression>(memberExpression.ObjectExpression));
            Steps.Add(new WriteDot());
            Steps.Add(new WriteName(memberExpression.MemberName));
        }

        public override void VisitMethodCallExpression<TExpression, TTypeReference, TArgument>(
            IMethodCallExpression<TExpression, TTypeReference, TArgument> methodCallExpression)
        {
            Steps.Add(new WriteExpression<TExpression>(methodCallExpression.Expression));
            if (methodCallExpression.GenericParameters.Count != 0)
            {
                Steps.AddGenericParameterSteps(methodCallExpression.GenericParameters);
            }

            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedExpressionSteps(methodCallExpression.Parameters);
            Steps.Add(new WriteEndParenthesis());
        }

        public override void VisitNewAnonymousArrayExpression(INewAnonymousArrayExpression newAnonymousArrayExpression)
        {
            Steps.Add(new WriteNewKeyword());
        }

        public override void VisitNewAnonymousTypeExpression(INewAnonymousTypeExpression newAnonymousTypeExpression)
        {
            Steps.Add(new WriteNewKeyword());
            Steps.Add(new WriteStartBracket());
            Steps.Add(new WriteEndBracket());
        }

        public override void VisitNewArrayExpression<TTypeReference, TExpression>(
            INewArrayExpression<TTypeReference, TExpression> newArrayExpression)
        {
            Steps.Add(new WriteNewKeyword());
            bool hasInitialSizeExpressions = newArrayExpression.InitialSizeExpressions.Count != 0;
            int dimensionsLength = newArrayExpression.Dimensions.Count;
            if (hasInitialSizeExpressions)
            {
                dimensionsLength--;
            }

            for (int index = 0; index < dimensionsLength; index++)
            {
                Steps.Add(new WriteStartBracket());
                for (int commaCount = 0; commaCount < newArrayExpression.Dimensions[index] - 1; commaCount++)
                {
                    Steps.Add(new WriteComma());
                }

                Steps.Add(new WriteEndBracket());
            }

            if (hasInitialSizeExpressions)
            {
                Steps.Add(new WriteStartBracket());
                Steps.AddCommaSeparatedExpressionSteps(newArrayExpression.InitialSizeExpressions);
                Steps.Add(new WriteEndBracket());
            }
        }

        public override void VisitNewExpression<TTypeReference, TExpression>(
            INewExpression<TTypeReference, TExpression> newExpression)
        {
            Steps.Add(new WriteNewKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(newExpression.Type));
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedExpressionSteps(newExpression.Parameters);
            Steps.Add(new WriteEndParenthesis());
        }

        public override void VisitNullExpression(INullExpression nullExpression)
        {
            Steps.Add(new WriteNullKeyword());
        }

        public override void VisitObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>(
            IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> objectInitializerExpression)
        {
            Steps.Add(new WriteExpression<TCreateObjectExpression>(objectInitializerExpression.CreateObjectExpression));
            Steps.AddObjectInitializerSteps(objectInitializerExpression);
        }

        public override void VisitOutArgument<TExpression>(IOutArgument<TExpression> outArgument)
        {
            Steps.Add(new WriteMethodParameterModifier(ParameterModifier.Out));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(outArgument.Expression));
        }

        public override void VisitParenthesisExpression<TExpression>(IParenthesisExpression<TExpression> parenthesisExpression)
        {
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteExpression<TExpression>(parenthesisExpression.Expression));
            Steps.Add(new WriteEndParenthesis());
        }

        public override void VisitQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>(IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> queryExpression)
        {
            Steps.Add(new WriteExpression<TQueryFromExpression>(queryExpression.StartExpression));
            Steps.Add(new IncrementIndent());
            foreach (TQueryClauseExpression expression in queryExpression.Expressions)
            {
                Steps.Add(new WriteIndentedNewLine());
                Steps.Add(new WriteExpression<TQueryClauseExpression>(expression));
            }

            Steps.Add(new WriteExpression<TQueryEndExpression>(queryExpression.EndExpression));
            Steps.Add(new DecrementIndent());
        }

        public override void VisitQueryFromExpression<TExpression>(
            IQueryFromExpression<TExpression> queryFromExpression)
        {
            Steps.Add(new WriteFromKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(queryFromExpression.Identifier));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteInKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(queryFromExpression.Expression));
        }

        public override void VisitQueryGroupExpression<TExpression>(
            IQueryGroupExpression<TExpression> queryGroupExpression)
        {
            Steps.Add(new WriteGroupKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(queryGroupExpression.GroupExpression));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteByKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(queryGroupExpression.ByExpression));
        }

        public override void VisitQueryGroupIntoExpression<TExpression, TIdentifierExpression>(
            IQueryGroupIntoExpression<TExpression, TIdentifierExpression> queryGroupIntoExpression)
        {
            VisitQueryGroupExpression(queryGroupIntoExpression);
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteIntoKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TIdentifierExpression>(queryGroupIntoExpression.IntoExpression));
        }

        public override void VisitQueryJoinExpression<TExpression>(
            IQueryJoinExpression<TExpression> queryJoinExpression)
        {
            Steps.Add(new WriteJoinKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(queryJoinExpression.JoinVariable));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteInKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(queryJoinExpression.InExpression));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteOnKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(queryJoinExpression.OnExpression));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEqualsKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(queryJoinExpression.EqualsExpression));
            if (queryJoinExpression.IntoVariable != null)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteIntoKeyword());
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteName(queryJoinExpression.IntoVariable));
            }
        }

        public override void VisitQueryLetExpression<TExpression>(
            IQueryLetExpression<TExpression> queryLetExpression)
        {
            Steps.Add(new WriteLetKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEqualsKeyword());
            Steps.Add(new WriteName(queryLetExpression.Identifier));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(queryLetExpression.Expression));
        }

        public override void VisitQueryOrderByExpression<TOrderingExpression>(
            IQueryOrderByExpression<TOrderingExpression> queryOrderByExpression)
        {
            Steps.Add(new WriteOrderByKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.AddCommaSeparatedExpressionSteps(queryOrderByExpression.Orders);
        }

        public override void VisitQueryOrderingExpression<TExpression>(IQueryOrderingExpression<TExpression> queryOrderingExpression)
        {
            Steps.Add(new WriteExpression<TExpression>(queryOrderingExpression.Expression));
            if (queryOrderingExpression.OrderByType != QueryOrderByType.None)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteQueryOrderByType(queryOrderingExpression.OrderByType));
            }
        }

        public override void VisitQuerySelectExpression<TExpression>(IQuerySelectExpression<TExpression> querySelectExpression)
        {
            Steps.Add(new WriteSelectKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(querySelectExpression.Expression));
        }

        public override void VisitQuerySelectIntoExpression<TExpression, TIdentifierExpression>(IQuerySelectIntoExpression<TExpression, TIdentifierExpression> querySelectIntoExpression)
        {
            VisitQuerySelectExpression(querySelectIntoExpression);
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteIntoKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TIdentifierExpression>(querySelectIntoExpression.IntoExpression));
        }

        public override void VisitQueryWhereExpression<TExpression>(IQueryWhereExpression<TExpression> queryWhereExpression)
        {
            Steps.Add(new WriteWhereKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(queryWhereExpression.Expression));
        }

        public override void VisitRawExpression(IRawExpression rawExpression)
        {
            Steps.Add(new WriteRawValue(rawExpression.Expression));
        }

        public override void VisitRefArgument<TExpression>(IRefArgument<TExpression> refArgument)
        {
            Steps.Add(new WriteMethodParameterModifier(ParameterModifier.Ref));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(refArgument.Expression));
        }

        public override void VisitStringConstantExpression(IStringConstantExpression stringConstantExpression)
        {
            bool hasAtSymbol = stringConstantExpression.HasAtSymbol;
            if (hasAtSymbol)
            {
                Steps.Add(new WriteAt());
            }

            string constant = stringConstantExpression.Constant;
            constant = hasAtSymbol ? constant.Replace("\"", "\"\"") : constant.Replace("\"", "\\\"");
            Steps.Add(new WriteStringConstant(constant));
        }

        public override void VisitTernaryOperatorExpression<TExpression>(
            ITernaryOperatorExpression<TExpression> ternaryOperatorExpression)
        {
            Steps.Add(new WriteExpression<TExpression>(ternaryOperatorExpression.Left));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteQuestionMark());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(ternaryOperatorExpression.Middle));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteColon());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(ternaryOperatorExpression.Right));
        }

        public override void VisitThisExpression(IThisExpression thisExpression)
        {
            Steps.Add(new WriteThisKeyword());
        }

        public override void VisitTypeofExpression<TTypeReference>(ITypeofExpression<TTypeReference> typeofExpression)
        {
            Steps.Add(new WriteTypeofKeyword());
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteChildNode<TTypeReference>(typeofExpression.Type));
            Steps.Add(new WriteEndParenthesis());
        }

        public override void VisitUnaryOperatorExpression<TExpression>(IUnaryOperatorExpression<TExpression> unaryOperatorExpression)
        {
            Steps.Add(new WriteUnaryOperatorExpressionType(unaryOperatorExpression.OperatorType));
            Steps.Add(new WriteExpression<TExpression>(unaryOperatorExpression.Operand));
        }
    }
}
