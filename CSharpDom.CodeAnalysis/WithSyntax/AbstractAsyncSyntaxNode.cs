using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public abstract class AbstractAsyncSyntaxNode
    {
        public abstract Task AcceptAsync(SyntaxVisitor visitor);
    }
}
