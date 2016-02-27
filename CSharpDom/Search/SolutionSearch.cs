using CSharpDom.Common;
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

        public Task<TClass> ClassByNameAsync<TClass>(string name)
            where TClass : IClass
        {
            return SearchSolutionAsync(new FindClassByNameVisitor<TClass>(name));
        }

        public Task<TAbstractClass> AbstractClassByNameAsync<TAbstractClass>(string name)
            where TAbstractClass : IAbstractClass
        {
            return SearchSolutionAsync(new FindAbstractClassByNameVisitor<TAbstractClass>(name));
        }

        public Task<TSealedClass> SealedClassByNameAsync<TSealedClass>(string name)
            where TSealedClass : ISealedClass
        {
            return SearchSolutionAsync(new FindSealedClassByNameVisitor<TSealedClass>(name));
        }

        public Task<TStaticClass> StaticClassByNameAsync<TStaticClass>(string name)
            where TStaticClass : IStaticClass
        {
            return SearchSolutionAsync(new FindStaticClassByNameVisitor<TStaticClass>(name));
        }

        public Task<TStruct> StructByNameAsync<TStruct>(string name)
            where TStruct : IStruct
        {
            return SearchSolutionAsync(new FindStructByNameVisitor<TStruct>(name));
        }

        private async Task<T> SearchSolutionAsync<T>(AbstractSearchVisitor<T> visitor)
        {
            await visitor.VisitSolutionAsync(solution);
            return visitor.Result;
        }
    }
}
