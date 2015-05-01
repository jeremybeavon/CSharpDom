using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class LinqExpressionsVisitorMapping : ILinqExpressionsVisitor
    {
        private readonly LinqExpressionsVisitor visitor;

        public LinqExpressionsVisitorMapping(LinqExpressionsVisitor visitor)
        {
            this.visitor = visitor;
        }

        public void VisitClass(IClassWithLinqExpressions node)
        {
            visitor.VisitClass(new ClassWithLinqExpressions(node));
        }

        public void VisitClassDeclaration(IClassDeclarationWithLinqExpressions node)
        {
            visitor.VisitClassDeclaration(new ClassDeclarationWithLinqExpressions(node));
        }

        public void VisitConstructor(IConstructorWithLinqExpressions node)
        {
            visitor.VisitConstructor(new ConstructorWithLinqExpressions(node));
        }

        public void VisitConversionOperator(IConversionOperatorWithLinqExpressions node)
        {
            visitor.VisitConversionOperator(new ConversionOperatorWithLinqExpressions(node));
        }

        public void VisitDelegate(IDelegateWithLinqExpressions node)
        {
            visitor.VisitDelegate(new DelegateWithLinqExpressions(node));
        }

        public void VisitDestructor(IDestructorWithLinqExpressions node)
        {
            visitor.VisitDestructor(new DestructorWithLinqExpressions(node));
        }

        public void VisitDocument(IDocumentWithLinqExpressions node)
        {
            visitor.VisitDocument(new DocumentWithLinqExpressions(node));
        }

        public void VisitEnum(IEnumWithLinqExpressions node)
        {
            visitor.VisitEnum(new EnumWithLinqExpressions(node));
        }

        public void VisitEnumMember(IEnumMemberWithLinqExpressions node)
        {
            visitor.VisitEnumMember(new EnumMemberWithLinqExpressions(node));
        }

        public void VisitEvent(IEventWithLinqExpressions node)
        {
            visitor.VisitEvent(new EventWithLinqExpressions(node));
        }

        public void VisitEventProperty(IEventPropertyWithLinqExpressions node)
        {
            visitor.VisitEventProperty(new EventPropertyWithLinqExpressions(node));
        }

        public void VisitField(IFieldWithLinqExpressions node)
        {
            visitor.VisitField(new FieldWithLinqExpressions(node));
        }

        public void VisitIndexer(IIndexerWithLinqExpressions node)
        {
            visitor.VisitIndexer(new IndexerWithLinqExpressions(node));
        }

        public void VisitInterface(IInterfaceWithLinqExpressions node)
        {
            visitor.VisitInterface(new InterfaceWithLinqExpressions(node));
        }

        public void VisitInterfaceDeclaration(IInterfaceDeclarationWithLinqExpressions node)
        {
            visitor.VisitInterfaceDeclaration(new InterfaceDeclarationWithLinqExpressions(node));
        }

        public void VisitMethod(IMethodWithLinqExpressions node)
        {
            visitor.VisitMethod(new MethodWithLinqExpressions(node));
        }

        public void VisitNamespace(INamespaceWithLinqExpressions node)
        {
            visitor.VisitNamespace(new NamespaceWithLinqExpressions(node));
        }

        public void VisitNestedClass(INestedClassWithLinqExpressions node)
        {
            visitor.VisitNestedClass(new NestedClassWithLinqExpressions(node));
        }

        public void VisitNestedClassDeclaration(INestedClassDeclarationWithLinqExpressions node)
        {
            visitor.VisitNestedClassDeclaration(new NestedClassDeclarationWithLinqExpressions(node));
        }

        public void VisitNestedDelegate(INestedDelegateWithLinqExpressions node)
        {
            visitor.VisitNestedDelegate(new NestedDelegateWithLinqExpressions(node));
        }

        public void VisitNestedDestructor(INestedDestructorWithLinqExpressions node)
        {
            visitor.VisitNestedDestructor(new NestedDestructorWithLinqExpressions(node));
        }

        public void VisitNestedEnum(INestedEnumWithLinqExpressions node)
        {
            visitor.VisitNestedEnum(new NestedEnumWithLinqExpressions(node));
        }

        public void VisitNestedEnumMember(INestedEnumMemberWithLinqExpressions node)
        {
            visitor.VisitNestedEnumMember(new NestedEnumMemberWithLinqExpressions(node));
        }

        public void VisitNestedInterface(INestedInterfaceWithLinqExpressions node)
        {
            visitor.VisitNestedInterface(new NestedInterfaceWithLinqExpressions(node));
        }

        public void VisitNestedInterfaceDeclaration(INestedInterfaceDeclarationWithLinqExpressions node)
        {
            visitor.VisitNestedInterfaceDeclaration(new NestedInterfaceDeclarationWithLinqExpressions(node));
        }

        public void VisitNestedStruct(INestedStructWithLinqExpressions node)
        {
            visitor.VisitNestedStruct(new NestedStructWithLinqExpressions(node));
        }

        public void VisitNestedStructDeclaration(INestedStructDeclarationWithLinqExpressions node)
        {
            visitor.VisitNestedStructDeclaration(new NestedStructDeclarationWithLinqExpressions(node));
        }

        public void VisitOperatorOverload(IOperatorOverloadWithLinqExpressions node)
        {
            visitor.VisitOperatorOverload(new OperatorOverloadWithLinqExpressions(node));
        }

        public Task VisitProjectAsync(IProjectWithLinqExpressions node)
        {
            return visitor.VisitProjectAsync(ProjectWithLinqExpressions.GetProject(node));
        }

        public void VisitProperty(IPropertyWithLinqExpressions node)
        {
            visitor.VisitProperty(new PropertyWithLinqExpressions(node));
        }

        public Task VisitSolutionAsync(ISolutionWithLinqExpressions node)
        {
            return visitor.VisitSolutionAsync(SolutionWithLinqExpressions.GetSolution(node));
        }

        public void VisitStruct(IStructWithLinqExpressions node)
        {
            visitor.VisitStruct(new StructWithLinqExpressions(node));
        }

        public void VisitStructDeclaration(IStructDeclarationWithLinqExpressions node)
        {
            visitor.VisitStructDeclaration(new StructDeclarationWithLinqExpressions(node));
        }
    }
}
