using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IEventPropertyWithReflection : IEventPropertyWithSymbol, IHasEventInfo,
        IHasDeclaringType<ITypeWithReflection>,
        IHasSyntax<IEventPropertySyntax>,
        IHasSymbols<IEventPropertyWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
