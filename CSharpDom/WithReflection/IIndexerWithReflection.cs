using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IIndexerWithReflection : IIndexerWithSymbol, IHasPropertyInfo,
        IHasDeclaringType<IBasicTypeWithReflection>,
        IHasSyntax<IIndexerSyntax>,
        IHasSymbols<IIndexerWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
