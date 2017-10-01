using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.Text
{
    public static class VisitableExtensions
    {
        public static string ToSourceCode(
            this IVisitable<IGenericVisitor> visitable,
            params ISourceCodeStyleRule[] styleRules)
        {
            SourceCodeStepsBuilder stepsBuilder = new SourceCodeStepsBuilder();
            visitable.Accept(stepsBuilder);
            return stepsBuilder.Steps.ToSourceCode(styleRules);
        }

        public static string ToSourceCode(
            this IVisitable<IGenericExpressionVisitor> visitable,
            params ISourceCodeStyleRule[] styleRules)
        {
            SourceCodeExpressionStepsBuilder stepsBuilder = new SourceCodeExpressionStepsBuilder();
            visitable.Accept(stepsBuilder);
            return stepsBuilder.Steps.ToSourceCode(styleRules);
        }

        public static string ToSourceCode(
            this IVisitable<IGenericStatementVisitor> visitable,
            params ISourceCodeStyleRule[] styleRules)
        {
            SourceCodeStatementStepsBuilder stepsBuilder = new SourceCodeStatementStepsBuilder();
            visitable.Accept(stepsBuilder);
            return stepsBuilder.Steps.ToSourceCode(styleRules);
        }
    }
}
