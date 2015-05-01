using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedEnumMemberWithLinqExpressions : IEnumMember,
        IHasDeclaringType<INestedEnumWithLinqExpressions>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<INestedEnumMemberSyntax>,
        IHasSymbols<INestedEnumMemberWithSymbols>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
