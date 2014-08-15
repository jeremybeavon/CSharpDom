using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedClassWithLinqExpressions : IClassWithSymbol, ITypeWithLinqExpressions, IHasType,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasSyntax<INestedClassSyntax>,
        IHasSymbols<INestedClassWithSymbols>,
        IHasReflection<INestedClassWithReflection>
    {
    }
}
