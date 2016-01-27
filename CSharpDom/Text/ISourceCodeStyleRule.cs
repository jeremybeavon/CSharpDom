using System.Collections.Generic;

namespace CSharpDom.Text
{
    public interface ISourceCodeStyleRule
    {
        void ApplyRule(List<ISourceCodeBuilderStep> steps);
    }
}
