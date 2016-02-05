using CSharpDom.Common;
using System.Linq;

namespace CSharpDom.Text
{
    public static class VisitableExtensions
    {
        public static string ToSourceCode(this IVisitable<IGenericVisitor> visitable, params ISourceCodeStyleRule[] styleRules)
        {
            SourceCodeStepsBuilder stepsBuilder = new SourceCodeStepsBuilder();
            visitable.Accept(stepsBuilder);
            return stepsBuilder.Steps.ToSourceCode(styleRules);
        }
    }
}
