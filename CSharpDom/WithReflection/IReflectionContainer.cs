using CSharpDom.Common;

namespace CSharpDom.WithReflection
{
    public interface IReflectionContainer
    {
        IAsyncEnumerable<INamespaceWithReflection, IDocumentWithReflection> Namespaces { get; }

        IAsyncEnumerable<IClassWithReflection, IDocumentWithReflection> Classes { get; }

        IAsyncEnumerable<IDelegateWithReflection, IDocumentWithReflection> Delegates { get; }

        IAsyncEnumerable<IEnumWithReflection, IDocumentWithReflection> Enums { get; }

        IAsyncEnumerable<IInterfaceWithReflection, IDocumentWithReflection> Interfaces { get; }

        IAsyncEnumerable<IStructWithReflection, IDocumentWithReflection> Structs { get; }
    }
}
