using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedDelegateWithLinqExpressions : IDelegateWithSymbol, IHasType,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasSyntax<INestedDelegateSyntax>,
        IHasSymbols<INestedDelegateWithSymbols>,
        IHasReflection<INestedDelegateWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
