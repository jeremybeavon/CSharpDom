using CSharpDom.Common;

namespace CSharpDom.WithLinqExpressions
{
    public interface ILinqExpressionContainer
    {
        IAsyncEnumerable<INamespaceWithLinqExpressions, IDocumentWithLinqExpressions> Namespaces { get; }

        IAsyncEnumerable<IClassWithLinqExpressions, IDocumentWithLinqExpressions> Classes { get; }

        IAsyncEnumerable<IDelegateWithLinqExpressions, IDocumentWithLinqExpressions> Delegates { get; }

        IAsyncEnumerable<IEnumWithLinqExpressions, IDocumentWithLinqExpressions> Enums { get; }

        IAsyncEnumerable<IInterfaceWithLinqExpressions, IDocumentWithLinqExpressions> Interfaces { get; }

        IAsyncEnumerable<IStructWithLinqExpressions, IDocumentWithLinqExpressions> Structs { get; }
    }
}
