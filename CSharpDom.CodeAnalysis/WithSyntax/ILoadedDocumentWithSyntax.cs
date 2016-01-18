using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface ILoadedDocumentWithSyntax :
        ILoadedDocument<ISolutionSyntax, IProjectSyntax, IDocumentSyntax, INamespaceSyntax, IClassSyntax, IDelegateSyntax, IEnumSyntax, IInterfaceSyntax, IStructSyntax>
    {
    }
}
