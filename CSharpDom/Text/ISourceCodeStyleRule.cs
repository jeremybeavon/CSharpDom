using System.Collections.Generic;

namespace CSharpDom.Text
{
    public interface ISourceCodeStyleRule
    {
        bool IsRuleAlreadyApplied { get; }

        void ApplyRule(List<ISourceCodeBuilderStep> steps);
    }
}
