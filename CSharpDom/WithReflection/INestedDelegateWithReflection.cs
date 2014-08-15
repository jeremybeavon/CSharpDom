using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface INestedDelegateWithReflection : IDelegateWithSymbol, IHasType,
        IHasDeclaringType<ITypeWithReflection>,
        IHasSyntax<INestedDelegateSyntax>,
        IHasSymbols<INestedDelegateWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
