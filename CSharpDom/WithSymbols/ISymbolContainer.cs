using CSharpDom.Common;

namespace CSharpDom.WithSymbols
{
    public interface ISymbolContainer
    {
        IAsyncEnumerable<INamespaceWithSymbols, IDocumentWithSymbols> Namespaces { get; }

        IAsyncEnumerable<IClassWithSymbols, IDocumentWithSymbols> Classes { get; }

        IAsyncEnumerable<IDelegateWithSymbols, IDocumentWithSymbols> Delegates { get; }

        IAsyncEnumerable<IEnumWithSymbols, IDocumentWithSymbols> Enums { get; }

        IAsyncEnumerable<IInterfaceWithSymbols, IDocumentWithSymbols> Interfaces { get; }

        IAsyncEnumerable<IStructWithSymbols, IDocumentWithSymbols> Structs { get; }
    }
}
