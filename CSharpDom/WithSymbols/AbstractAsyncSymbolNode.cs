using System.Threading.Tasks;

namespace CSharpDom.WithSymbols
{
    public abstract class AbstractAsyncSymbolNode
    {
        public abstract Task AcceptAsync(SymbolsVisitor visitor);
    }
}
