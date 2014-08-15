using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface INamespaceWithReflection : INamespace,
        IHasClasses<IClassWithReflection>,
        IHasDelegates<IDelegateWithReflection>,
        IHasEnums<IEnumWithReflection>,
        IHasInterfaces<IInterfaceWithReflection>,
        IHasStructs<IStructWithReflection>,
        IHasSyntax<INamespaceSyntax>,
        IHasSymbols<INamespaceWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
