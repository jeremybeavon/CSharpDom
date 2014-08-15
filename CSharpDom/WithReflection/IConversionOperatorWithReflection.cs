using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IConversionOperatorWithReflection : IConversionOperatorWithSymbol, IHasMethodInfo,
        IHasDeclaringType<ITypeWithReflection>,
        IHasSyntax<IConversionOperatorSyntax>,
        IHasSymbols<IConversionOperatorWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
