using System.Collections.Generic;

namespace CSharpDom.Text
{
    public sealed class ChildSteps
    {
        internal ChildSteps(object @object, List<ISourceCodeBuilderStep> steps)
        {
            Object = @object;
            Steps = steps;
        }

        public object Object { get; private set; }

        public List<ISourceCodeBuilderStep> Steps { get; private set; }
    }
}
