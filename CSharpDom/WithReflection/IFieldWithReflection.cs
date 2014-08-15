using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IFieldWithReflection : IFieldWithSymbol, IHasFieldInfo,
        IHasDeclaringType<ITypeWithReflection>,
        IHasSyntax<IFieldSyntax>,
        IHasSymbols<IFieldWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
