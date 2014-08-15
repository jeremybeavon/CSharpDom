using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IDestructorWithReflection : IDestructorWithSymbol, IHasMethodInfo,
        IHasDeclaringType<IClassDeclarationWithReflection>,
        IHasSyntax<IDestructorSyntax>,
        IHasSymbols<IDestructorWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
