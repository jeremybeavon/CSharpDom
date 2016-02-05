using CSharpDom.Common;
using System.Threading.Tasks;

namespace CSharpDom.Text
{
    public static class AsyncVisitableExtensions
    {
        public static async Task<string> ToSourceCodeAsync(
            this IAsyncVisitable<IGenericVisitor> visitable,
            params ISourceCodeStyleRule[] styleRules)
        {
            SourceCodeStepsBuilder stepsBuilder = new SourceCodeStepsBuilder();
            await visitable.AcceptAsync(stepsBuilder);
            return stepsBuilder.Steps.ToSourceCode(styleRules);
        }
    }
}
