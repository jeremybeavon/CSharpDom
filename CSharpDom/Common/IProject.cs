using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IProject<TSolution, TDocument, TLoadedProject> :
        IHasSolution<TSolution>,
        IHasDocuments<TDocument>
    {
        Task<TLoadedProject> LoadAsync();
    }
}
