using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithReflection.Internal
{
    internal sealed class ReflectionVisitorMapping : IReflectionVisitor
    {
        private readonly ReflectionVisitor visitor;

        public ReflectionVisitorMapping(ReflectionVisitor visitor)
        {
            this.visitor = visitor;
        }

        public void VisitClass(IClassWithReflection node)
        {
            visitor.VisitClass(new ClassWithReflection(node));
        }

        public void VisitClassDeclaration(IClassDeclarationWithReflection node)
        {
            visitor.VisitClassDeclaration(new ClassDeclarationWithReflection(node));
        }

        public void VisitConstructor(IConstructorWithReflection node)
        {
            visitor.VisitConstructor(new ConstructorWithReflection(node));
        }

        public void VisitConversionOperator(IConversionOperatorWithReflection node)
        {
            visitor.VisitConversionOperator(new ConversionOperatorWithReflection(node));
        }

        public void VisitDelegate(IDelegateWithReflection node)
        {
            visitor.VisitDelegate(new DelegateWithReflection(node));
        }

        public void VisitDestructor(IDestructorWithReflection node)
        {
            visitor.VisitDestructor(new DestructorWithReflection(node));
        }

        public void VisitDocument(IDocumentWithReflection node)
        {
            visitor.VisitDocument(new DocumentWithReflection(node));
        }

        public void VisitEnum(IEnumWithReflection node)
        {
            visitor.VisitEnum(new EnumWithReflection(node));
        }

        public void VisitEnumMember(IEnumMemberWithReflection node)
        {
            visitor.VisitEnumMember(new EnumMemberWithReflection(node));
        }

        public void VisitEvent(IEventWithReflection node)
        {
            visitor.VisitEvent(new EventWithReflection(node));
        }

        public void VisitEventProperty(IEventPropertyWithReflection node)
        {
            visitor.VisitEventProperty(new EventPropertyWithReflection(node));
        }

        public void VisitField(IFieldWithReflection node)
        {
            visitor.VisitField(new FieldWithReflection(node));
        }

        public void VisitIndexer(IIndexerWithReflection node)
        {
            visitor.VisitIndexer(new IndexerWithReflection(node));
        }

        public void VisitInterface(IInterfaceWithReflection node)
        {
            visitor.VisitInterface(new InterfaceWithReflection(node));
        }

        public void VisitInterfaceDeclaration(IInterfaceDeclarationWithReflection node)
        {
            visitor.VisitInterfaceDeclaration(new InterfaceDeclarationWithReflection(node));
        }

        public void VisitMethod(IMethodWithReflection node)
        {
            visitor.VisitMethod(new MethodWithReflection(node));
        }

        public void VisitNamespace(INamespaceWithReflection node)
        {
            visitor.VisitNamespace(new NamespaceWithReflection(node));
        }

        public void VisitNestedClass(INestedClassWithReflection node)
        {
            visitor.VisitNestedClass(new NestedClassWithReflection(node));
        }

        public void VisitNestedClassDeclaration(INestedClassDeclarationWithReflection node)
        {
            visitor.VisitNestedClassDeclaration(new NestedClassDeclarationWithReflection(node));
        }

        public void VisitNestedDelegate(INestedDelegateWithReflection node)
        {
            visitor.VisitNestedDelegate(new NestedDelegateWithReflection(node));
        }

        public void VisitNestedDestructor(INestedDestructorWithReflection node)
        {
            visitor.VisitNestedDestructor(new NestedDestructorWithReflection(node));
        }

        public void VisitNestedEnum(INestedEnumWithReflection node)
        {
            visitor.VisitNestedEnum(new NestedEnumWithReflection(node));
        }

        public void VisitNestedEnumMember(INestedEnumMemberWithReflection node)
        {
            visitor.VisitNestedEnumMember(new NestedEnumMemberWithReflection(node));
        }

        public void VisitNestedInterface(INestedInterfaceWithReflection node)
        {
            visitor.VisitNestedInterface(new NestedInterfaceWithReflection(node));
        }

        public void VisitNestedInterfaceDeclaration(INestedInterfaceDeclarationWithReflection node)
        {
            visitor.VisitNestedInterfaceDeclaration(new NestedInterfaceDeclarationWithReflection(node));
        }

        public void VisitNestedStruct(INestedStructWithReflection node)
        {
            visitor.VisitNestedStruct(new NestedStructWithReflection(node));
        }

        public void VisitNestedStructDeclaration(INestedStructDeclarationWithReflection node)
        {
            visitor.VisitNestedStructDeclaration(new NestedStructDeclarationWithReflection(node));
        }

        public void VisitOperatorOverload(IOperatorOverloadWithReflection node)
        {
            visitor.VisitOperatorOverload(new OperatorOverloadWithReflection(node));
        }

        public Task VisitProjectAsync(IProjectWithReflection node)
        {
            return visitor.VisitProjectAsync(ProjectWithReflection.GetProject(node));
        }

        public void VisitProperty(IPropertyWithReflection node)
        {
            visitor.VisitProperty(new PropertyWithReflection(node));
        }

        public Task VisitSolutionAsync(ISolutionWithReflection node)
        {
            return visitor.VisitSolutionAsync(SolutionWithReflection.GetSolution(node));
        }

        public void VisitStruct(IStructWithReflection node)
        {
            visitor.VisitStruct(new StructWithReflection(node));
        }

        public void VisitStructDeclaration(IStructDeclarationWithReflection node)
        {
            visitor.VisitStructDeclaration(new StructDeclarationWithReflection(node));
        }
    }
}
