using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IMethodWithReflection : IMethodWithSymbol, IHasMethodInfo,
        IHasDeclaringType<IBasicTypeWithReflection>,
        IHasSyntax<IMethodSyntax>,
        IHasSymbols<IMethodWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
