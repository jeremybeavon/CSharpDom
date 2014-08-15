using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INestedEnumMemberSyntax : IEnumMember,
        IHasDeclaringType<INestedEnumSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
