using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal sealed class SymbolsNodeVisitor : NodeVisitor
    {
        private readonly ISymbolsVisitor visitor;

        public SymbolsNodeVisitor(ISymbolsVisitor visitor)
        {
            this.visitor = visitor;
        }

        public override void VisitClass(ClassNode node)
        {
            visitor.VisitClass((IClassWithSymbols)node);
        }
        
        public override void VisitConstructor(ConstructorNode node)
        {
            visitor.VisitConstructor((IConstructorWithSymbols)node);
        }

        public override void VisitConversionOperator(ConversionOperatorNode node)
        {
            visitor.VisitConversionOperator((IConversionOperatorWithSymbols)node);
        }

        public override void VisitDelegate(DelegateNode node)
        {
            visitor.VisitDelegate((IDelegateWithSymbols)node);
        }

        public override void VisitDestructor(DestructorNode node)
        {
            visitor.VisitDestructor((IDestructorWithSymbols)node);
        }

        public override void VisitDocument(DocumentNode node)
        {
            visitor.VisitDocument((IDocumentWithSymbols)node);
        }

        public override void VisitEnum(EnumNode node)
        {
            visitor.VisitEnum((IEnumWithSymbols)node);
        }

        public override void VisitEnumMember(EnumMemberNode node)
        {
            visitor.VisitEnumMember((IEnumMemberWithSymbols)node);
        }

        public override void VisitEvent(EventNode node)
        {
            visitor.VisitEvent((IEventWithSymbols)node);
        }

        public override void VisitEventProperty(EventPropertyNode node)
        {
            visitor.VisitEventProperty((IEventPropertyWithSymbols)node);
        }

        public override void VisitField(FieldNode node)
        {
            visitor.VisitField((IFieldWithSymbols)node);
        }

        public override void VisitIndexer(IndexerNode node)
        {
            visitor.VisitIndexer((IIndexerWithSymbols)node);
        }

        public override void VisitInterface(InterfaceNode node)
        {
            visitor.VisitInterface((IInterfaceWithSymbols)node);
        }
        
        public override void VisitMethod(MethodNode node)
        {
            visitor.VisitMethod((IMethodWithSymbols)node);
        }

        public override void VisitNamespace(NamespaceNode node)
        {
            visitor.VisitNamespace((INamespaceWithSymbols)node);
        }

        public override void VisitNestedClass(ClassNode node)
        {
            visitor.VisitNestedClass((INestedClassWithSymbols)node);
        }
        
        public override void VisitNestedDelegate(DelegateNode node)
        {
            visitor.VisitNestedDelegate((INestedDelegateWithSymbols)node);
        }

        public override void VisitNestedDestructor(DestructorNode node)
        {
            visitor.VisitNestedDestructor((INestedDestructorWithSymbols)node);
        }

        public override void VisitNestedEnum(EnumNode node)
        {
            visitor.VisitNestedEnum((INestedEnumWithSymbols)node);
        }

        public override void VisitNestedEnumMember(EnumMemberNode node)
        {
            visitor.VisitNestedEnumMember((INestedEnumMemberWithSymbols)node);
        }

        public override void VisitNestedInterface(InterfaceNode node)
        {
            visitor.VisitNestedInterface((INestedInterfaceWithSymbols)node);
        }
        
        public override void VisitNestedStruct(StructNode node)
        {
            visitor.VisitNestedStruct((INestedStructWithSymbols)node);
        }
        
        public override void VisitOperatorOverload(OperatorOverloadNode node)
        {
            visitor.VisitOperatorOverload((IOperatorOverloadWithSymbols)node);
        }

        public override Task VisitProjectAsync(ProjectNode node)
        {
            return visitor.VisitProjectAsync((IProjectWithSymbols)node);
        }

        public override void VisitProperty(PropertyNode node)
        {
            visitor.VisitProperty((IPropertyWithSymbols)node);
        }

        public override Task VisitSolutionAsync(SolutionNode node)
        {
            return visitor.VisitSolutionAsync((ISolutionWithSymbols)node);
        }

        public override void VisitStruct(StructNode node)
        {
            visitor.VisitStruct((IStructWithSymbols)node);
        }
    }
}
