using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Search
{
    public sealed class SolutionSearch<TProject>
        where TProject : IProject
    {
        private readonly ISolution<TProject> solution;

        public SolutionSearch(ISolution<TProject> solution)
        {
            this.solution = solution;
        }

        public Task<TClass> FindClassByNameAsync<TClass>(string name)
            where TClass : IClass
        {
            return SearchSolutionAsync(new FindClassByNameVisitor<TClass>(name));
        }

        private async Task<T> SearchSolutionAsync<T>(AbstractSearchVisitor<T> visitor)
        {
            await visitor.VisitSolutionAsync(solution);
            return visitor.Result;
        }
    }
}
