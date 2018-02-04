using System.Threading.Tasks;

namespace CSharpDom.Common.Editable
{
    public interface IEditableProject<TSolution, TDocument, TLoadedProject> :
        IEditableProject,
        IHasEditableSolution<TSolution>,
        IHasEditableDocuments<TDocument>,
        IProject<TSolution, TDocument, TLoadedProject>
        where TSolution : IEditableSolution
        where TDocument : IEditableDocument
        where TLoadedProject : IEditableLoadedProject
    {
    }
}