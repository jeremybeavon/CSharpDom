using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public abstract class AbstractAsyncSymbolNode
    {
        public abstract Task AcceptAsync(SymbolsVisitor visitor);
    }
}
