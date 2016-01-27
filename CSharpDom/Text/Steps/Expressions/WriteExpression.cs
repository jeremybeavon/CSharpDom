using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteExpression<TExpression> : ISourceCodeBuilderStep, IHasSourceSourceBuilderSteps
        where TExpression : IVisitable<IGenericExpressionVisitor>
    {
        public WriteExpression(TExpression expression)
        {
            Expression = expression;
            SourceCodeExpressionStepsBuilder builder = new SourceCodeExpressionStepsBuilder();
            expression.Accept(builder);
            Steps = builder.Steps;
        }

        public TExpression Expression { get; private set; }

        public List<ISourceCodeBuilderStep> Steps { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            foreach (ISourceCodeBuilderStep step in Steps)
            {
                step.AddText(builder);
            }
        }
    }
}
