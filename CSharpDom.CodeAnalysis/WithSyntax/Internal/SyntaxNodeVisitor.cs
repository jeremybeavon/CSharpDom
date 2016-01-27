using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal sealed class SyntaxNodeVisitor : NodeVisitor
    {
        private readonly ISyntaxVisitor visitor;

        public SyntaxNodeVisitor(ISyntaxVisitor visitor)
        {
            this.visitor = visitor;
        }

        public override void VisitClass(ClassNode node)
        {
            visitor.VisitClass((IClassSyntax)node);
        }

        public override void VisitClassDeclaration(ClassDeclarationNode node)
        {
            visitor.VisitClassDeclaration((IClassDeclarationSyntax)node);
        }

        public override void VisitConstructor(ConstructorNode node)
        {
            visitor.VisitConstructor((IConstructorSyntax)node);
        }

        public override void VisitConversionOperator(ConversionOperatorNode node)
        {
            visitor.VisitConversionOperator((IConversionOperatorSyntax)node);
        }

        public override void VisitDelegate(DelegateNode node)
        {
            visitor.VisitDelegate((IDelegateSyntax)node);
        }

        public override void VisitDestructor(DestructorNode node)
        {
            visitor.VisitDestructor((IDestructorSyntax)node);
        }

        public override void VisitDocument(DocumentNode node)
        {
            visitor.VisitDocument((IDocumentSyntax)node);
        }

        public override void VisitEnum(EnumNode node)
        {
            visitor.VisitEnum((IEnumSyntax)node);
        }

        public override void VisitEnumMember(EnumMemberNode node)
        {
            visitor.VisitEnumMember((IEnumMemberSyntax)node);
        }

        public override void VisitEvent(EventNode node)
        {
            visitor.VisitEvent((IEventSyntax)node);
        }

        public override void VisitEventProperty(EventPropertyNode node)
        {
            visitor.VisitEventProperty((IEventPropertySyntax)node);
        }

        public override void VisitField(FieldNode node)
        {
            visitor.VisitField((IFieldSyntax)node);
        }

        public override void VisitIndexer(IndexerNode node)
        {
            visitor.VisitIndexer((IIndexerSyntax)node);
        }

        public override void VisitInterface(InterfaceNode node)
        {
            visitor.VisitInterface((IInterfaceSyntax)node);
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationNode node)
        {
            visitor.VisitInterfaceDeclaration((IInterfaceDeclarationSyntax)node);
        }

        public override void VisitMethod(MethodNode node)
        {
            visitor.VisitMethod((IMethodSyntax)node);
        }

        public override void VisitNamespace(NamespaceNode node)
        {
            visitor.VisitNamespace((INamespaceSyntax)node);
        }

        public override void VisitNestedClass(ClassNode node)
        {
            visitor.VisitNestedClass((INestedClassSyntax)node);
        }

        public override void VisitNestedClassDeclaration(ClassDeclarationNode node)
        {
            visitor.VisitNestedClassDeclaration((INestedClassDeclarationSyntax)node);
        }

        public override void VisitNestedDelegate(DelegateNode node)
        {
            visitor.VisitNestedDelegate((INestedDelegateSyntax)node);
        }

        public override void VisitNestedDestructor(DestructorNode node)
        {
            visitor.VisitNestedDestructor((INestedDestructorSyntax)node);
        }

        public override void VisitNestedEnum(EnumNode node)
        {
            visitor.VisitNestedEnum((INestedEnumSyntax)node);
        }

        public override void VisitNestedEnumMember(EnumMemberNode node)
        {
            visitor.VisitNestedEnumMember((INestedEnumMemberSyntax)node);
        }

        public override void VisitNestedInterface(InterfaceNode node)
        {
            visitor.VisitNestedInterface((INestedInterfaceSyntax)node);
        }

        public override void VisitNestedInterfaceDeclaration(InterfaceDeclarationNode node)
        {
            visitor.VisitNestedInterfaceDeclaration((INestedInterfaceDeclarationSyntax)node);
        }

        public override void VisitNestedStruct(StructNode node)
        {
            visitor.VisitNestedStruct((INestedStructSyntax)node);
        }

        public override void VisitNestedStructDeclaration(StructDeclarationNode node)
        {
            visitor.VisitNestedStructDeclaration((INestedStructDeclarationSyntax)node);
        }

        public override void VisitOperatorOverload(OperatorOverloadNode node)
        {
            visitor.VisitOperatorOverload((IOperatorOverloadSyntax)node);
        }

        public override Task VisitProjectAsync(ProjectNode node)
        {
            return visitor.VisitProjectAsync((IProjectSyntax)node);
        }

        public override void VisitProperty(PropertyNode node)
        {
            visitor.VisitProperty((IPropertySyntax)node);
        }

        public override Task VisitSolutionAsync(SolutionNode node)
        {
            return visitor.VisitSolutionAsync((ISolutionSyntax)node);
        }

        public override void VisitStruct(StructNode node)
        {
            visitor.VisitStruct((IStructSyntax)node);
        }

        public override void VisitStructDeclaration(StructDeclarationNode node)
        {
            visitor.VisitStructDeclaration((IStructDeclarationSyntax)node);
        }
    }
}
