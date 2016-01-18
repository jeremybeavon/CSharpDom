using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal sealed class SyntaxVisitorMapping : ISyntaxVisitor
    {
        private readonly SyntaxVisitor visitor;

        public SyntaxVisitorMapping(SyntaxVisitor visitor)
        {
            this.visitor = visitor;
        }

        public void VisitClass(IClassSyntax node)
        {
            visitor.VisitClass(new ClassWithSyntax(node));
        }

        public void VisitClassDeclaration(IClassDeclarationSyntax node)
        {
            visitor.VisitClassDeclaration(new ClassDeclarationWithSyntax(node));
        }

        public void VisitConstructor(IConstructorSyntax node)
        {
            visitor.VisitConstructor(new ConstructorWithSyntax(node));
        }

        public void VisitConversionOperator(IConversionOperatorSyntax node)
        {
            visitor.VisitConversionOperator(new ConversionOperatorWithSyntax(node));
        }

        public void VisitDelegate(IDelegateSyntax node)
        {
            visitor.VisitDelegate(new DelegateWithSyntax(node));
        }

        public void VisitDestructor(IDestructorSyntax node)
        {
            visitor.VisitDestructor(new DestructorWithSyntax(node));
        }

        public void VisitDocument(IDocumentSyntax node)
        {
            visitor.VisitDocument(new DocumentWithSyntax(node));
        }

        public void VisitEnum(IEnumSyntax node)
        {
            visitor.VisitEnum(new EnumWithSyntax(node));
        }

        public void VisitEnumMember(IEnumMemberSyntax node)
        {
            visitor.VisitEnumMember(new EnumMemberWithSyntax(node));
        }

        public void VisitEvent(IEventSyntax node)
        {
            visitor.VisitEvent(new EventWithSyntax(node));
        }

        public void VisitEventProperty(IEventPropertySyntax node)
        {
            visitor.VisitEventProperty(new EventPropertyWithSyntax(node));
        }

        public void VisitField(IFieldSyntax node)
        {
            visitor.VisitField(new FieldWithSyntax(node));
        }

        public void VisitIndexer(IIndexerSyntax node)
        {
            visitor.VisitIndexer(new IndexerWithSyntax(node));
        }

        public void VisitInterface(IInterfaceSyntax node)
        {
            visitor.VisitInterface(new InterfaceWithSyntax(node));
        }

        public void VisitInterfaceDeclaration(IInterfaceDeclarationSyntax node)
        {
            visitor.VisitInterfaceDeclaration(new InterfaceDeclarationWithSyntax(node));
        }

        public void VisitMethod(IMethodSyntax node)
        {
            visitor.VisitMethod(new MethodWithSyntax(node));
        }

        public void VisitNamespace(INamespaceSyntax node)
        {
            visitor.VisitNamespace(new NamespaceWithSyntax(node));
        }

        public void VisitNestedClass(INestedClassSyntax node)
        {
            visitor.VisitNestedClass(new NestedClassWithSyntax(node));
        }

        public void VisitNestedClassDeclaration(INestedClassDeclarationSyntax node)
        {
            visitor.VisitNestedClassDeclaration(new NestedClassDeclarationWithSyntax(node));
        }

        public void VisitNestedDelegate(INestedDelegateSyntax node)
        {
            visitor.VisitNestedDelegate(new NestedDelegateWithSyntax(node));
        }

        public void VisitNestedDestructor(INestedDestructorSyntax node)
        {
            visitor.VisitNestedDestructor(new NestedDestructorWithSyntax(node));
        }

        public void VisitNestedEnum(INestedEnumSyntax node)
        {
            visitor.VisitNestedEnum(new NestedEnumWithSyntax(node));
        }

        public void VisitNestedEnumMember(INestedEnumMemberSyntax node)
        {
            visitor.VisitNestedEnumMember(new NestedEnumMemberWithSyntax(node));
        }

        public void VisitNestedInterface(INestedInterfaceSyntax node)
        {
            visitor.VisitNestedInterface(new NestedInterfaceWithSyntax(node));
        }

        public void VisitNestedInterfaceDeclaration(INestedInterfaceDeclarationSyntax node)
        {
            visitor.VisitNestedInterfaceDeclaration(new NestedInterfaceDeclarationWithSyntax(node));
        }

        public void VisitNestedStruct(INestedStructSyntax node)
        {
            visitor.VisitNestedStruct(new NestedStructWithSyntax(node));
        }

        public void VisitNestedStructDeclaration(INestedStructDeclarationSyntax node)
        {
            visitor.VisitNestedStructDeclaration(new NestedStructDeclarationWithSyntax(node));
        }

        public void VisitOperatorOverload(IOperatorOverloadSyntax node)
        {
            visitor.VisitOperatorOverload(new OperatorOverloadWithSyntax(node));
        }

        public Task VisitProjectAsync(IProjectSyntax node)
        {
            return visitor.VisitProjectAsync(ProjectWithSyntax.GetProject(node));
        }

        public void VisitProperty(IPropertySyntax node)
        {
            visitor.VisitProperty(new PropertyWithSyntax(node));
        }

        public Task VisitSolutionAsync(ISolutionSyntax node)
        {
            return visitor.VisitSolutionAsync(SolutionWithSyntax.GetSolution(node));
        }

        public void VisitStruct(IStructSyntax node)
        {
            visitor.VisitStruct(new StructWithSyntax(node));
        }

        public void VisitStructDeclaration(IStructDeclarationSyntax node)
        {
            visitor.VisitStructDeclaration(new StructDeclarationWithSyntax(node));
        }
    }
}
