using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IOperatorOverloadWithReflection : IOperatorOverloadWithSymbol, IHasMethodInfo,
        IHasDeclaringType<ITypeWithReflection>,
        IHasSyntax<IOperatorOverloadSyntax>, 
        IHasSymbols<IOperatorOverloadWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
