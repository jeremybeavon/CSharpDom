using System.Threading.Tasks;

namespace CSharpDom.Common.Editable
{
    public interface IEditableProject : IAsyncVisitable<IEditableVisitor>, IProject
    {
    }
}