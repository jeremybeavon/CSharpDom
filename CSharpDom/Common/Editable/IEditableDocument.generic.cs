using System.Threading.Tasks;

namespace CSharpDom.Common.Editable
{
    public interface IEditableDocument<TProject, TSolution, TLoadedDocument> :
        IEditableDocument,
        IHasEditableProject<TProject>,
        IHasEditableSolution<TSolution>,
        IDocument<TProject, TSolution, TLoadedDocument>
        where TProject : IEditableProject
        where TSolution : IEditableSolution
        where TLoadedDocument : IEditableLoadedDocument
    {
        new string FullFilePath { get; set; }
    }
}