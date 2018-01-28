using CSharpDom.Common;
using CSharpDom.Text.Steps;
using System.Collections.Generic;

namespace CSharpDom.Text.Rules
{
    public sealed class IndentBaseTypeListIfTooLongRule : ISourceCodeStyleRule
    {
        public IndentBaseTypeListIfTooLongRule(int maximumLineLength)
        {
            MaximumLineLength = maximumLineLength;
        }

        public int MaximumLineLength { get; private set; }

        public bool IsRuleAlreadyApplied => false;

        public void ApplyRule(List<ISourceCodeBuilderStep> steps)
        {
            foreach (ChildSteps typeSteps in steps.GetChildSteps(typeof(IClassType), typeof(IInterfaceType), typeof(IStructType)))
            {
                SourceCodeStepRange range = typeSteps.Steps.GetRange(
                    SourceCodePlaceholder.BeginBaseTypeList,
                    SourceCodePlaceholder.EndBaseTypeList);
                int typeDefinitionLength = typeSteps.Steps.GetRange(
                    SourceCodePlaceholder.BeginTypeDefinition,
                    SourceCodePlaceholder.EndTypeDefinition).Range.FindFirstLine().ToSourceCode().Length;
                if (range == null || typeDefinitionLength <= MaximumLineLength)
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
