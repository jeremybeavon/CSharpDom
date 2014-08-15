using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public interface INestedEnumWithReflection : IEnum, IHasDeclaringType<ITypeWithReflection>,
        IHasEnumMembers<INestedEnumMemberWithReflection>,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<INestedEnumSyntax>,
        IHasSymbols<INestedEnumWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
