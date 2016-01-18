using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IClassWithSymbols : 
        IClass<INamespaceWithSymbols, IProjectWithSymbols, ISolutionWithSymbols, IEventWithSymbols, IPropertyWithSymbols, IIndexerWithSymbols, IMethodWithSymbols, IFieldWithSymbols, IConstructorWithSymbols, IEventPropertyWithSymbols, IOperatorOverloadWithSymbols, IConversionOperatorWithSymbols, INestedClassWithSymbols, INestedDelegateWithSymbols, INestedEnumWithSymbols, INestedInterfaceWithSymbols, INestedStructWithSymbols, IDestructorWithSymbols>,
        ITypeWithSymbols,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<IClassSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
