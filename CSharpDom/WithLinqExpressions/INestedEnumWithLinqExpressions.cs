using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedEnumWithLinqExpressions : IEnum, IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasEnumMembers<INestedEnumMemberWithLinqExpressions>,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<INestedEnumSyntax>,
        IHasSymbols<INestedEnumWithSymbols>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
