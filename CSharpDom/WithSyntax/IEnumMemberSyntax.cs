using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IEnumMemberSyntax : IEnumMember,
        IHasDeclaringType<IEnumSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
