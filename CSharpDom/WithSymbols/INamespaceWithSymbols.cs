using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface INamespaceWithSymbols : INamespace,
        IHasClasses<IClassWithSymbols>,
        IHasDelegates<IDelegateWithSymbols>,
        IHasEnums<IEnumWithSymbols>,
        IHasInterfaces<IInterfaceWithSymbols>,
        IHasStructs<IStructWithSymbols>,
        IHasSyntax<INamespaceSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
