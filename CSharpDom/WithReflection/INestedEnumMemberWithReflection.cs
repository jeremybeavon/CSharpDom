using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public interface INestedEnumMemberWithReflection : IEnumMember,
        IHasDeclaringType<INestedEnumWithReflection>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<INestedEnumMemberSyntax>,
        IHasSymbols<INestedEnumMemberWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
