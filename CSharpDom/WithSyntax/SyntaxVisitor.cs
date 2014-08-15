using System.Threading.Tasks;

namespace CSharpDom.WithSyntax
{
    public abstract class SyntaxVisitor
    {
        public virtual void DefaultVisit(AbstractSyntaxNode node)
        {
            node.Accept(this);
        }

        public virtual Task DefaultVisitAsync(AbstractAsyncSyntaxNode node)
        {
            return node.AcceptAsync(this);
        }

        public virtual void VisitClassDeclaration(ClassDeclarationWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitClass(ClassWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitConstructor(ConstructorWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitConversionOperator(ConversionOperatorWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDelegate(DelegateWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDestructor(DestructorWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDocument(DocumentWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEnumMember(EnumMemberWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEnum(EnumWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEvent(EventWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEventProperty(EventPropertyWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitField(FieldWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitIndexer(IndexerWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitInterfaceDeclaration(InterfaceDeclarationWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitInterface(InterfaceWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitMethod(MethodWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNamespace(NamespaceWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedClassDeclaration(NestedClassDeclarationWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedClass(NestedClassWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedDelegate(NestedDelegateWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedDestructor(NestedDestructorWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedEnum(NestedEnumWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedEnumMember(NestedEnumMemberWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedInterfaceDeclaration(NestedInterfaceDeclarationWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedInterface(NestedInterfaceWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedStructDeclaration(NestedStructDeclarationWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedStruct(NestedStructWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitOperatorOverload(OperatorOverloadWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual Task VisitProjectAsync(ProjectWithSyntax node)
        {
            return DefaultVisitAsync(node);
        }

        public virtual void VisitProperty(PropertyWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual Task VisitSolutionAsync(SolutionWithSyntax node)
        {
            return DefaultVisitAsync(node);
        }

        public virtual void VisitStructDeclaration(StructDeclarationWithSyntax node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitStruct(StructWithSyntax node)
        {
            DefaultVisit(node);
        }
    }
}
