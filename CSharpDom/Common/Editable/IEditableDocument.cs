using System.Threading.Tasks;

namespace CSharpDom.Common.Editable
{
    public interface IEditableDocument : IAsyncVisitable<IEditableVisitor>, IDocument
    {
    }
}