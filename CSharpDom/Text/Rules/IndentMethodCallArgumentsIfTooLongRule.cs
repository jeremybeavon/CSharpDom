using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Text.Rules
{
    public sealed class IndentMethodCallArgumentsIfTooLongRule : ISourceCodeStyleRule
    {
        public IndentMethodCallArgumentsIfTooLongRule(int maximumLineLength)
        {
            MaximumLineLength = maximumLineLength;
        }

        public int MaximumLineLength { get; private set; }

        public bool IsRuleAlreadyApplied => false;

        public void ApplyRule(List<ISourceCodeBuilderStep> steps)
        {
            foreach (ChildSteps statementSteps in steps.GetChildSteps(typeof(IExpressionStatement)))
            {

                /*SourceCodeStepRange range = methodSteps.Steps.GetRange(
                    SourceCodePlaceholder.BeginMethodParametersDefinition,
                    SourceCodePlaceholder.EndMethodParametersDefinition);
                int methodDefinitionLength = methodSteps.Steps.GetRange(
                    SourceCodePlaceholder.BeginMethodDefinition,
                    SourceCodePlaceholder.EndMethodDefinition).Range.FindFirstLine().ToSourceCode().Length;
                if (range == null || methodDefinitionLength <= MaximumLineLength)
                {
                    continue;
                }

                range.Range.Insert(0, new IncrementIndent());
                range.Range.Insert(1, new WriteIndentedNewLine());
                range.Range.Add(new DecrementIndent());
                range.Range.ReplaceAll(typeof(WriteWhitespace), new WriteIndentedNewLine());
                range.Apply();*/
            }
        }
    }
}

    {
    }
}
