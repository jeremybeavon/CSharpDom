using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IDocument<TProject, TSolution, TLoadedDocument> :
        IDocument,
        IHasProject<TProject>,
        IHasSolution<TSolution>
        where TProject : IProject
        where TSolution : ISolution
        where TLoadedDocument : ILoadedDocument
    {
        string FullFilePath { get; }

        Task<TLoadedDocument> LoadAsync();
    }
}
