using System.Threading.Tasks;

namespace CSharpDom
{
    internal abstract class AbstractAsyncNode
    {
        public abstract Task AcceptAsync(NodeVisitor visitor);
    }
}
