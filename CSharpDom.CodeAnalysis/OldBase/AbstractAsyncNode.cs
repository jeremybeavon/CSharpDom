using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class AbstractAsyncNode
    {
        public abstract Task AcceptAsync(NodeVisitor visitor);
    }
}
