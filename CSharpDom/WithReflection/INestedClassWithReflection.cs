using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface INestedClassWithReflection : IClassWithSymbol, ITypeWithReflection, IHasType,
        IHasDeclarations<INestedClassDeclarationWithReflection>,
        IHasDeclaringType<ITypeWithReflection>,
        IHasDestructor<INestedDestructorWithReflection>,
        IHasSyntax<INestedClassSyntax>,
        IHasSymbols<INestedClassWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
