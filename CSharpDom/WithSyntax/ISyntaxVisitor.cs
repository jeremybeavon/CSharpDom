using System.Threading.Tasks;

namespace CSharpDom.WithSyntax
{
    public interface ISyntaxVisitor
    {
        void VisitClassDeclaration(IClassDeclarationSyntax node);

        void VisitClass(IClassSyntax node);

        void VisitConstructor(IConstructorSyntax node);

        void VisitConversionOperator(IConversionOperatorSyntax node);

        void VisitDelegate(IDelegateSyntax node);

        void VisitDestructor(IDestructorSyntax node);

        void VisitDocument(IDocumentSyntax node);

        void VisitEnumMember(IEnumMemberSyntax node);

        void VisitEnum(IEnumSyntax node);

        void VisitEvent(IEventSyntax node);

        void VisitEventProperty(IEventPropertySyntax node);

        void VisitField(IFieldSyntax node);

        void VisitIndexer(IIndexerSyntax node);

        void VisitInterfaceDeclaration(IInterfaceDeclarationSyntax node);

        void VisitInterface(IInterfaceSyntax node);

        void VisitMethod(IMethodSyntax node);

        void VisitNamespace(INamespaceSyntax node);

        void VisitNestedClassDeclaration(INestedClassDeclarationSyntax node);

        void VisitNestedClass(INestedClassSyntax node);

        void VisitNestedDelegate(INestedDelegateSyntax node);

        void VisitNestedDestructor(INestedDestructorSyntax node);

        void VisitNestedEnum(INestedEnumSyntax node);

        void VisitNestedEnumMember(INestedEnumMemberSyntax node);

        void VisitNestedInterfaceDeclaration(INestedInterfaceDeclarationSyntax node);

        void VisitNestedInterface(INestedInterfaceSyntax node);

        void VisitNestedStructDeclaration(INestedStructDeclarationSyntax node);

        void VisitNestedStruct(INestedStructSyntax node);

        void VisitOperatorOverload(IOperatorOverloadSyntax node);

        Task VisitProjectAsync(IProjectSyntax node);

        void VisitProperty(IPropertySyntax node);

        Task VisitSolutionAsync(ISolutionSyntax node);

        void VisitStructDeclaration(IStructDeclarationSyntax node);

        void VisitStruct(IStructSyntax node);
    }
}
