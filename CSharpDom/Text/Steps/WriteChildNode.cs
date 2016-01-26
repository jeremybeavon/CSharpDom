using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteChildNode<TChildNode> : ISourceCodeBuilderStep, IHasSourceSourceBuilderSteps
        where TChildNode : IVisitable<IGenericVisitor>
    {
        public WriteChildNode(TChildNode childNode, SourceCodeStepsBuilder builder = null)
        {
            ChildNode = childNode;
            if (builder == null)
            {
                builder = new SourceCodeStepsBuilder();
            }

            childNode.Accept(builder);
            Steps = builder.Steps;
        }

        public TChildNode ChildNode { get; private set; }

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
