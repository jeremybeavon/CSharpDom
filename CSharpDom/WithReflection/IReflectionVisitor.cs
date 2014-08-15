using System.Threading.Tasks;

namespace CSharpDom.WithReflection
{
    public interface IReflectionVisitor
    {
        void VisitClassDeclaration(IClassDeclarationWithReflection node);

        void VisitClass(IClassWithReflection node);

        void VisitConstructor(IConstructorWithReflection node);

        void VisitConversionOperator(IConversionOperatorWithReflection node);

        void VisitDelegate(IDelegateWithReflection node);

        void VisitDestructor(IDestructorWithReflection node);

        void VisitDocument(IDocumentWithReflection node);

        void VisitEnumMember(IEnumMemberWithReflection node);

        void VisitEnum(IEnumWithReflection node);

        void VisitEvent(IEventWithReflection node);

        void VisitEventProperty(IEventPropertyWithReflection node);

        void VisitField(IFieldWithReflection node);

        void VisitIndexer(IIndexerWithReflection node);

        void VisitInterfaceDeclaration(IInterfaceDeclarationWithReflection node);

        void VisitInterface(IInterfaceWithReflection node);

        void VisitMethod(IMethodWithReflection node);

        void VisitNamespace(INamespaceWithReflection node);

        void VisitNestedClassDeclaration(INestedClassDeclarationWithReflection node);

        void VisitNestedClass(INestedClassWithReflection node);

        void VisitNestedDelegate(INestedDelegateWithReflection node);

        void VisitNestedDestructor(INestedDestructorWithReflection node);

        void VisitNestedEnum(INestedEnumWithReflection node);

        void VisitNestedEnumMember(INestedEnumMemberWithReflection node);

        void VisitNestedInterfaceDeclaration(INestedInterfaceDeclarationWithReflection node);

        void VisitNestedInterface(INestedInterfaceWithReflection node);

        void VisitNestedStructDeclaration(INestedStructDeclarationWithReflection node);

        void VisitNestedStruct(INestedStructWithReflection node);

        void VisitOperatorOverload(IOperatorOverloadWithReflection node);

        Task VisitProjectAsync(IProjectWithReflection node);

        void VisitProperty(IPropertyWithReflection node);

        Task VisitSolutionAsync(ISolutionWithReflection node);

        void VisitStructDeclaration(IStructDeclarationWithReflection node);

        void VisitStruct(IStructWithReflection node);
    }
}
