using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithReflection.Internal
{
    internal sealed class ReflectionNodeVisitor : NodeVisitor
    {
        private readonly IReflectionVisitor visitor;

        public ReflectionNodeVisitor(IReflectionVisitor visitor)
        {
            this.visitor = visitor;
        }

        public override void VisitClass(ClassNode node)
        {
            visitor.VisitClass((IClassWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitClassDeclaration(ClassDeclarationNode node)
        {
            visitor.VisitClassDeclaration((IClassDeclarationWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitConstructor(ConstructorNode node)
        {
            visitor.VisitConstructor((IConstructorWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitConversionOperator(ConversionOperatorNode node)
        {
            visitor.VisitConversionOperator((IConversionOperatorWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitDelegate(DelegateNode node)
        {
            visitor.VisitDelegate((IDelegateWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitDestructor(DestructorNode node)
        {
            visitor.VisitDestructor((IDestructorWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitDocument(DocumentNode node)
        {
            visitor.VisitDocument((IDocumentWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitEnum(EnumNode node)
        {
            visitor.VisitEnum((IEnumWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitEnumMember(EnumMemberNode node)
        {
            visitor.VisitEnumMember((IEnumMemberWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitEvent(EventNode node)
        {
            visitor.VisitEvent((IEventWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitEventProperty(EventPropertyNode node)
        {
            visitor.VisitEventProperty((IEventPropertyWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitField(FieldNode node)
        {
            visitor.VisitField((IFieldWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitIndexer(IndexerNode node)
        {
            visitor.VisitIndexer((IIndexerWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitInterface(InterfaceNode node)
        {
            visitor.VisitInterface((IInterfaceWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationNode node)
        {
            visitor.VisitInterfaceDeclaration((IInterfaceDeclarationWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitMethod(MethodNode node)
        {
            visitor.VisitMethod((IMethodWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNamespace(NamespaceNode node)
        {
            visitor.VisitNamespace((INamespaceWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedClass(ClassNode node)
        {
            visitor.VisitNestedClass((INestedClassWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedClassDeclaration(ClassDeclarationNode node)
        {
            visitor.VisitNestedClassDeclaration((INestedClassDeclarationWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedDelegate(DelegateNode node)
        {
            visitor.VisitNestedDelegate((INestedDelegateWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedDestructor(DestructorNode node)
        {
            visitor.VisitNestedDestructor((INestedDestructorWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedEnum(EnumNode node)
        {
            visitor.VisitNestedEnum((INestedEnumWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedEnumMember(EnumMemberNode node)
        {
            visitor.VisitNestedEnumMember((INestedEnumMemberWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedInterface(InterfaceNode node)
        {
            visitor.VisitNestedInterface((INestedInterfaceWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedInterfaceDeclaration(InterfaceDeclarationNode node)
        {
            visitor.VisitNestedInterfaceDeclaration((INestedInterfaceDeclarationWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedStruct(StructNode node)
        {
            visitor.VisitNestedStruct((INestedStructWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitNestedStructDeclaration(StructDeclarationNode node)
        {
            visitor.VisitNestedStructDeclaration((INestedStructDeclarationWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitOperatorOverload(OperatorOverloadNode node)
        {
            visitor.VisitOperatorOverload((IOperatorOverloadWithReflection)node);
            DefaultVisit(node);
        }

        public override async Task VisitProjectAsync(ProjectNode node)
        {
            await visitor.VisitProjectAsync((IProjectWithReflection)node);
            await DefaultVisitAsync(node);
        }

        public override void VisitProperty(PropertyNode node)
        {
            visitor.VisitProperty((IPropertyWithReflection)node);
            DefaultVisit(node);
        }

        public override async Task VisitSolutionAsync(SolutionNode node)
        {
            await visitor.VisitSolutionAsync((ISolutionWithReflection)node);
            await DefaultVisitAsync(node);
        }

        public override void VisitStruct(StructNode node)
        {
            visitor.VisitStruct((IStructWithReflection)node);
            DefaultVisit(node);
        }

        public override void VisitStructDeclaration(StructDeclarationNode node)
        {
            visitor.VisitStructDeclaration((IStructDeclarationWithReflection)node);
            DefaultVisit(node);
        }
    }
}
