using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface ILoadedProjectWithSymbols
        : ILoadedProject<ISolutionWithSymbols, IProjectWithSymbols, INamespaceWithSymbols, IClassWithSymbols, IDelegateWithSymbols, IEnumWithSymbols, IInterfaceWithSymbols, IStructWithSymbols>
    {
    }
}
