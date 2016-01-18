using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IDocument<TProject, TSolution, TLoadedDocument> :
        IHasProject<TProject>,
        IHasSolution<TSolution>
    {
        string FullFilePath { get; }

        Task<TLoadedDocument> LoadAsync();
    }
}
