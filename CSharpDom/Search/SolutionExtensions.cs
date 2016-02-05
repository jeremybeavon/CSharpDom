using CSharpDom.Common;

namespace CSharpDom.Search
{
    public static class SolutionExtensions
    {
        public static SolutionSearch<TProject> Find<TProject>(this ISolution<TProject> solution)
            where TProject : IProject
        {
            return new SolutionSearch<TProject>(solution);
        }
    }
}
