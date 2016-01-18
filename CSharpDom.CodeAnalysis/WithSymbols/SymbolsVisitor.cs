using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public abstract class SymbolsVisitor
    {
        public virtual void DefaultVisit(AbstractSymbolNode node)
        {
            node.Accept(this);
        }

        public virtual Task DefaultVisitAsync(AbstractAsyncSymbolNode node)
        {
            return node.AcceptAsync(this);
        }

        public virtual void VisitClass(ClassWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitConstructor(ConstructorWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitConversionOperator(ConversionOperatorWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDelegate(DelegateWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDestructor(DestructorWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDocument(DocumentWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEnumMember(EnumMemberWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEnum(EnumWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEvent(EventWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEventProperty(EventPropertyWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitField(FieldWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitIndexer(IndexerWithSymbols node)
        {
            DefaultVisit(node);
        }
        
        public virtual void VisitInterface(InterfaceWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitMethod(MethodWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNamespace(NamespaceWithSymbols node)
        {
            DefaultVisit(node);
        }
        
        public virtual void VisitNestedClass(NestedClassWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedDelegate(NestedDelegateWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedDestructor(NestedDestructorWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedEnum(NestedEnumWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedEnumMember(NestedEnumMemberWithSymbols node)
        {
            DefaultVisit(node);
        }
        
        public virtual void VisitNestedInterface(NestedInterfaceWithSymbols node)
        {
            DefaultVisit(node);
        }
        
        public virtual void VisitNestedStruct(NestedStructWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitOperatorOverload(OperatorOverloadWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual Task VisitProjectAsync(ProjectWithSymbols node)
        {
            return DefaultVisitAsync(node);
        }

        public virtual void VisitProperty(PropertyWithSymbols node)
        {
            DefaultVisit(node);
        }

        public virtual Task VisitSolutionAsync(SolutionWithSymbols node)
        {
            return DefaultVisitAsync(node);
        }
        
        public virtual void VisitStruct(StructWithSymbols node)
        {
            DefaultVisit(node);
        }
    }
}
