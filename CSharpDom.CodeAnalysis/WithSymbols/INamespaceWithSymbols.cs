using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface INamespaceWithSymbols :
        INamespace<IClassWithSymbols, IDelegateWithSymbols, IEnumWithSymbols, IInterfaceWithSymbols, IStructWithSymbols>,
        IHasSyntax<INamespaceSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
