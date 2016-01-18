using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface INestedClassWithSymbols :
        INestedClass<ITypeWithSymbols, IEventWithSymbols, IPropertyWithSymbols, IIndexerWithSymbols, IMethodWithSymbols, IFieldWithSymbols, IConstructorWithSymbols, IEventPropertyWithSymbols, IOperatorOverloadWithSymbols, IConversionOperatorWithSymbols, INestedClassWithSymbols, INestedDelegateWithSymbols, INestedEnumWithSymbols, INestedInterfaceWithSymbols, INestedStructWithSymbols, INestedDestructorWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        ITypeWithSymbols,
        IHasSyntax<INestedClassSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
