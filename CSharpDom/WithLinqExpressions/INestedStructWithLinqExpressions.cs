using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedStructWithLinqExpressions : IStruct, ITypeWithLinqExpressions,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasDeclarations<INestedStructDeclarationWithLinqExpressions>,
        IHasSyntax<INestedStructSyntax>,
        IHasSymbols<INestedStructWithSymbols>,
        IHasReflection<INestedStructWithReflection>
    {
    }
}
