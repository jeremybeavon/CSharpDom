using System.Threading.Tasks;

namespace CSharpDom.WithLinqExpressions
{
    public interface ILinqExpressionsVisitor
    {
        void VisitClassDeclaration(IClassDeclarationWithLinqExpressions node);

        void VisitClass(IClassWithLinqExpressions node);

        void VisitConstructor(IConstructorWithLinqExpressions node);

        void VisitConversionOperator(IConversionOperatorWithLinqExpressions node);

        void VisitDelegate(IDelegateWithLinqExpressions node);

        void VisitDestructor(IDestructorWithLinqExpressions node);

        void VisitDocument(IDocumentWithLinqExpressions node);

        void VisitEnumMember(IEnumMemberWithLinqExpressions node);

        void VisitEnum(IEnumWithLinqExpressions node);

        void VisitEvent(IEventWithLinqExpressions node);

        void VisitEventProperty(IEventPropertyWithLinqExpressions node);

        void VisitField(IFieldWithLinqExpressions node);

        void VisitIndexer(IIndexerWithLinqExpressions node);

        void VisitInterfaceDeclaration(IInterfaceDeclarationWithLinqExpressions node);

        void VisitInterface(IInterfaceWithLinqExpressions node);

        void VisitMethod(IMethodWithLinqExpressions node);

        void VisitNamespace(INamespaceWithLinqExpressions node);

        void VisitNestedClassDeclaration(INestedClassDeclarationWithLinqExpressions node);

        void VisitNestedClass(INestedClassWithLinqExpressions node);

        void VisitNestedDelegate(INestedDelegateWithLinqExpressions node);

        void VisitNestedDestructor(INestedDestructorWithLinqExpressions node);

        void VisitNestedEnum(INestedEnumWithLinqExpressions node);

        void VisitNestedEnumMember(INestedEnumMemberWithLinqExpressions node);

        void VisitNestedInterfaceDeclaration(INestedInterfaceDeclarationWithLinqExpressions node);

        void VisitNestedInterface(INestedInterfaceWithLinqExpressions node);

        void VisitNestedStructDeclaration(INestedStructDeclarationWithLinqExpressions node);

        void VisitNestedStruct(INestedStructWithLinqExpressions node);

        void VisitOperatorOverload(IOperatorOverloadWithLinqExpressions node);

        Task VisitProjectAsync(IProjectWithLinqExpressions node);

        void VisitProperty(IPropertyWithLinqExpressions node);

        Task VisitSolutionAsync(ISolutionWithLinqExpressions node);

        void VisitStructDeclaration(IStructDeclarationWithLinqExpressions node);

        void VisitStruct(IStructWithLinqExpressions node);
    }
}
