using System.Threading.Tasks;

namespace CSharpDom.WithSyntax
{
    public abstract class AbstractAsyncSyntaxNode
    {
        public abstract Task AcceptAsync(SyntaxVisitor visitor);
    }
}
