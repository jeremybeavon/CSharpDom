using System.Collections.Generic;

namespace CSharpDom.Text
{
    public class SourceCodeExpressionStepsBuilder : IHasSourceSourceBuilderSteps
    {
        public SourceCodeExpressionStepsBuilder()
        {
            Steps = new List<ISourceCodeBuilderStep>();
        }

        public List<ISourceCodeBuilderStep> Steps { get; private set; }
    }
}
