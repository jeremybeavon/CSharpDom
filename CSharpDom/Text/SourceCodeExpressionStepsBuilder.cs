using CSharpDom.BaseClasses.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Text
{
    public class SourceCodeExpressionStepsBuilder : AbstractGenericExpressionVisitor, IHasSourceSourceBuilderSteps
    {
        public SourceCodeExpressionStepsBuilder()
        {
            Steps = new List<ISourceCodeBuilderStep>();
        }

        public List<ISourceCodeBuilderStep> Steps { get; private set; }
    }
}
