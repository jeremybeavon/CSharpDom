using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IPropertyWithReflection : IPropertyWithSymbol, IHasPropertyInfo,
        IHasDeclaringType<IBasicTypeWithReflection>,
        IHasSyntax<IPropertySyntax>,
        IHasSymbols<IPropertyWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
