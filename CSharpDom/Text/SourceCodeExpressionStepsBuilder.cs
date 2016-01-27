using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Text
{
    public class SourceCodeExpressionStepsBuilder : IGenericExpressionVisitor, IHasSourceSourceBuilderSteps
    {
        public SourceCodeExpressionStepsBuilder()
        {
            Steps = new List<ISourceCodeBuilderStep>();
        }

        public List<ISourceCodeBuilderStep> Steps { get; private set; }
    }
}
