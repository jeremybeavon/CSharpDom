using CSharpDom.Common;
using CSharpDom.Text.Steps;
using System.Collections.Generic;

namespace CSharpDom.Text.Rules
{
    public sealed class IndentMethodParametersIfTooLongRule : ISourceCodeStyleRule
    {
        public IndentMethodParametersIfTooLongRule(int maximumLineLength)
        {
            MaximumLineLength = maximumLineLength;
        }

        public int MaximumLineLength { get; private set; }

        public bool IsRuleAlreadyApplied => false;

        public void ApplyRule(List<ISourceCodeBuilderStep> steps)
        {
            foreach (ChildSteps methodSteps in steps.GetChildSteps(typeof(IInterfaceMethod)))
            {
                SourceCodeStepRange range = methodSteps.Steps.GetRange(
                    SourceCodePlaceholder.BeginMethodParametersDefinition,
                    SourceCodePlaceholder.BeginMethodParametersDefinition);
                int methodDefinitionLength = methodSteps.Steps.GetRange(
                    SourceCodePlaceholder.BeginMethodDefinition,
                    SourceCodePlaceholder.EndMethodDefinition).Range.FindFirstLine().ToSourceCode().Length;
                if (range == null || range.Range.FindFirstLine().ToSourceCode().Length <= MaximumLineLength)
                {
                    continue;
                }

                range.Range.Insert(0, new IncrementIndent());
                range.Range.Add(new DecrementIndent());
                range.Range.ReplaceAll(typeof(WriteWhitespace), new WriteIndentedNewLine());
                range.Apply();
            }
        }
    }
}
