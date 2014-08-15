using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IEnumSyntax : IEnum,
        IHasEnumMembers<IEnumMemberSyntax>,
        IHasNamespace<INamespaceSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
