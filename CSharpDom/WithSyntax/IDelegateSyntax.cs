using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IDelegateSyntax : IDelegate,
        IHasNamespace<INamespaceSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
