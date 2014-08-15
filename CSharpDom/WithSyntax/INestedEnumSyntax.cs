using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INestedEnumSyntax : IEnum, IHasDeclaringType<ITypeSyntax>,
        IHasEnumMembers<INestedEnumMemberSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
