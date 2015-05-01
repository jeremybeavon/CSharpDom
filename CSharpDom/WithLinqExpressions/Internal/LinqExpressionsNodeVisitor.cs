using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class LinqExpressionsNodeVisitor : NodeVisitor
    {
        private readonly ILinqExpressionsVisitor visitor;

        public LinqExpressionsNodeVisitor(ILinqExpressionsVisitor visitor)
        {
            this.visitor = visitor;
        }

        public override void VisitClass(ClassNode node)
        {
            visitor.VisitClass((IClassWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitClassDeclaration(ClassDeclarationNode node)
        {
            visitor.VisitClassDeclaration((IClassDeclarationWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitConstructor(ConstructorNode node)
        {
            visitor.VisitConstructor((IConstructorWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitConversionOperator(ConversionOperatorNode node)
        {
            visitor.VisitConversionOperator((IConversionOperatorWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitDelegate(DelegateNode node)
        {
            visitor.VisitDelegate((IDelegateWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitDestructor(DestructorNode node)
        {
            visitor.VisitDestructor((IDestructorWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitDocument(DocumentNode node)
        {
            visitor.VisitDocument((IDocumentWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitEnum(EnumNode node)
        {
            visitor.VisitEnum((IEnumWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitEnumMember(EnumMemberNode node)
        {
            visitor.VisitEnumMember((IEnumMemberWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitEvent(EventNode node)
        {
            visitor.VisitEvent((IEventWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitEventProperty(EventPropertyNode node)
        {
            visitor.VisitEventProperty((IEventPropertyWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitField(FieldNode node)
        {
            visitor.VisitField((IFieldWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitIndexer(IndexerNode node)
        {
            visitor.VisitIndexer((IIndexerWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitInterface(InterfaceNode node)
        {
            visitor.VisitInterface((IInterfaceWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationNode node)
        {
            visitor.VisitInterfaceDeclaration((IInterfaceDeclarationWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitMethod(MethodNode node)
        {
            visitor.VisitMethod((IMethodWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNamespace(NamespaceNode node)
        {
            visitor.VisitNamespace((INamespaceWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedClass(ClassNode node)
        {
            visitor.VisitNestedClass((INestedClassWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedClassDeclaration(ClassDeclarationNode node)
        {
            visitor.VisitNestedClassDeclaration((INestedClassDeclarationWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedDelegate(DelegateNode node)
        {
            visitor.VisitNestedDelegate((INestedDelegateWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedDestructor(DestructorNode node)
        {
            visitor.VisitNestedDestructor((INestedDestructorWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedEnum(EnumNode node)
        {
            visitor.VisitNestedEnum((INestedEnumWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedEnumMember(EnumMemberNode node)
        {
            visitor.VisitNestedEnumMember((INestedEnumMemberWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedInterface(InterfaceNode node)
        {
            visitor.VisitNestedInterface((INestedInterfaceWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedInterfaceDeclaration(InterfaceDeclarationNode node)
        {
            visitor.VisitNestedInterfaceDeclaration((INestedInterfaceDeclarationWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedStruct(StructNode node)
        {
            visitor.VisitNestedStruct((INestedStructWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitNestedStructDeclaration(StructDeclarationNode node)
        {
            visitor.VisitNestedStructDeclaration((INestedStructDeclarationWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitOperatorOverload(OperatorOverloadNode node)
        {
            visitor.VisitOperatorOverload((IOperatorOverloadWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override async Task VisitProjectAsync(ProjectNode node)
        {
            await visitor.VisitProjectAsync((IProjectWithLinqExpressions)node);
            await DefaultVisitAsync(node);
        }

        public override void VisitProperty(PropertyNode node)
        {
            visitor.VisitProperty((IPropertyWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override async Task VisitSolutionAsync(SolutionNode node)
        {
            await visitor.VisitSolutionAsync((ISolutionWithLinqExpressions)node);
            await DefaultVisitAsync(node);
        }

        public override void VisitStruct(StructNode node)
        {
            visitor.VisitStruct((IStructWithLinqExpressions)node);
            DefaultVisit(node);
        }

        public override void VisitStructDeclaration(StructDeclarationNode node)
        {
            visitor.VisitStructDeclaration((IStructDeclarationWithLinqExpressions)node);
            DefaultVisit(node);
        }
    }
}
