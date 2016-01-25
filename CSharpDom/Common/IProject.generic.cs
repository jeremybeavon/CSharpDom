using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IProject<TSolution, TDocument, TLoadedProject> :
        IProject,
        IHasSolution<TSolution>,
        IHasDocuments<TDocument>
        where TSolution : ISolution
        where TDocument : IDocument
        where TLoadedProject : ILoadedProject
    {
        Task<TLoadedProject> LoadAsync();
    }
}
