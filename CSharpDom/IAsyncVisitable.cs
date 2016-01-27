using System.Threading.Tasks;

namespace CSharpDom
{
    public interface IAsyncVisitable<TVisitor>
    {
        Task AcceptAsync(TVisitor visitor);

        Task AcceptChildrenAsync(TVisitor visitor);
    }
}
