using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface ISymbolsVisitor
    {
        void VisitClass(IClassWithSymbols node);

        void VisitConstructor(IConstructorWithSymbols node);

        void VisitConversionOperator(IConversionOperatorWithSymbols node);

        void VisitDelegate(IDelegateWithSymbols node);

        void VisitDestructor(IDestructorWithSymbols node);

        void VisitDocument(IDocumentWithSymbols node);

        void VisitEnumMember(IEnumMemberWithSymbols node);

        void VisitEnum(IEnumWithSymbols node);

        void VisitEvent(IEventWithSymbols node);

        void VisitEventProperty(IEventPropertyWithSymbols node);

        void VisitField(IFieldWithSymbols node);

        void VisitIndexer(IIndexerWithSymbols node);

        void VisitInterface(IInterfaceWithSymbols node);

        void VisitMethod(IMethodWithSymbols node);

        void VisitNamespace(INamespaceWithSymbols node);

        void VisitNestedClass(INestedClassWithSymbols node);

        void VisitNestedDelegate(INestedDelegateWithSymbols node);

        void VisitNestedDestructor(INestedDestructorWithSymbols node);

        void VisitNestedEnum(INestedEnumWithSymbols node);

        void VisitNestedEnumMember(INestedEnumMemberWithSymbols node);

        void VisitNestedInterface(INestedInterfaceWithSymbols node);

        void VisitNestedStruct(INestedStructWithSymbols node);

        void VisitOperatorOverload(IOperatorOverloadWithSymbols node);

        Task VisitProjectAsync(IProjectWithSymbols node);

        void VisitProperty(IPropertyWithSymbols node);

        Task VisitSolutionAsync(ISolutionWithSymbols node);

        void VisitStruct(IStructWithSymbols node);
    }
}
