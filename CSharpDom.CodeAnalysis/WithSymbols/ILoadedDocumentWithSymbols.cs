using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface ILoadedDocumentWithSymbols :
        ILoadedDocument<ISolutionWithSymbols, IProjectWithSymbols, IDocumentWithSymbols, INamespaceWithSymbols, IClassWithSymbols, IDelegateWithSymbols, IEnumWithSymbols, IInterfaceWithSymbols, IStructWithSymbols>
    {
    }
}
