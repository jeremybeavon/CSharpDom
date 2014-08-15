using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IConstructorWithReflection : IConstructorWithSymbol, IHasConstructorInfo,
        IHasDeclaringType<ITypeWithReflection>,
        IHasSyntax<IConstructorSyntax>,
        IHasSymbols<IConstructorWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
