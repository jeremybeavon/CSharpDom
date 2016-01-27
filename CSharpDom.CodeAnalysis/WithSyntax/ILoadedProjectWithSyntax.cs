using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface ILoadedProjectWithSyntax :
        ILoadedProject<ISolutionSyntax, IProjectSyntax, INamespaceSyntax, IClassSyntax, IDelegateSyntax, IEnumSyntax, IInterfaceSyntax, IStructSyntax>
    {
    }
}
