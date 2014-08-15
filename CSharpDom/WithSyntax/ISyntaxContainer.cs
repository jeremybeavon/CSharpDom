using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface ISyntaxContainer
    {
        IAsyncEnumerable<INamespaceSyntax, IDocumentSyntax> Namespaces { get; }

        IAsyncEnumerable<IClassSyntax, IDocumentSyntax> Classes { get; }

        IAsyncEnumerable<IDelegateSyntax, IDocumentSyntax> Delegates { get; }

        IAsyncEnumerable<IEnumSyntax, IDocumentSyntax> Enums { get; }

        IAsyncEnumerable<IInterfaceSyntax, IDocumentSyntax> Interfaces { get; }

        IAsyncEnumerable<IStructSyntax, IDocumentSyntax> Structs { get; }
    }
}
