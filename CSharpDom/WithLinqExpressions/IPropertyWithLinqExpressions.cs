using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IPropertyWithLinqExpressions : IPropertyWithSymbol, IHasPropertyInfo,
        IHasDeclaringType<IBasicTypeWithLinqExpressions>,
        IHasSyntax<IPropertySyntax>,
        IHasSymbols<IPropertyWithSymbols>,
        IHasReflection<IPropertyWithReflection>
    {
    }
}
