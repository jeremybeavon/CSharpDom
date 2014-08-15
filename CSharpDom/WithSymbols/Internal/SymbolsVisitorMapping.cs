using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithSymbols.Internal
{
    internal sealed class SymbolsVisitorMapping : ISymbolsVisitor
    {
        private readonly SymbolsVisitor visitor;

        public SymbolsVisitorMapping(SymbolsVisitor visitor)
        {
            this.visitor = visitor;
        }

        public void VisitClass(IClassWithSymbols node)
        {
            visitor.VisitClass(new ClassWithSymbols(node));
        }

        public void VisitClassDeclaration(IClassDeclarationWithSymbols node)
        {
            visitor.VisitClassDeclaration(new ClassDeclarationWithSymbols(node));
        }

        public void VisitConstructor(IConstructorWithSymbols node)
        {
            visitor.VisitConstructor(new ConstructorWithSymbols(node));
        }

        public void VisitConversionOperator(IConversionOperatorWithSymbols node)
        {
            visitor.VisitConversionOperator(new ConversionOperatorWithSymbols(node));
        }

        public void VisitDelegate(IDelegateWithSymbols node)
        {
            visitor.VisitDelegate(new DelegateWithSymbols(node));
        }

        public void VisitDestructor(IDestructorWithSymbols node)
        {
            visitor.VisitDestructor(new DestructorWithSymbols(node));
        }

        public void VisitDocument(IDocumentWithSymbols node)
        {
            visitor.VisitDocument(new DocumentWithSymbols(node));
        }

        public void VisitEnum(IEnumWithSymbols node)
        {
            visitor.VisitEnum(new EnumWithSymbols(node));
        }

        public void VisitEnumMember(IEnumMemberWithSymbols node)
        {
            visitor.VisitEnumMember(new EnumMemberWithSymbols(node));
        }

        public void VisitEvent(IEventWithSymbols node)
        {
            visitor.VisitEvent(new EventWithSymbols(node));
        }

        public void VisitEventProperty(IEventPropertyWithSymbols node)
        {
            visitor.VisitEventProperty(new EventPropertyWithSymbols(node));
        }

        public void VisitField(IFieldWithSymbols node)
        {
            visitor.VisitField(new FieldWithSymbols(node));
        }

        public void VisitIndexer(IIndexerWithSymbols node)
        {
            visitor.VisitIndexer(new IndexerWithSymbols(node));
        }

        public void VisitInterface(IInterfaceWithSymbols node)
        {
            visitor.VisitInterface(new InterfaceWithSymbols(node));
        }

        public void VisitInterfaceDeclaration(IInterfaceDeclarationWithSymbols node)
        {
            visitor.VisitInterfaceDeclaration(new InterfaceDeclarationWithSymbols(node));
        }

        public void VisitMethod(IMethodWithSymbols node)
        {
            visitor.VisitMethod(new MethodWithSymbols(node));
        }

        public void VisitNamespace(INamespaceWithSymbols node)
        {
            visitor.VisitNamespace(new NamespaceWithSymbols(node));
        }

        public void VisitNestedClass(INestedClassWithSymbols node)
        {
            visitor.VisitNestedClass(new NestedClassWithSymbols(node));
        }

        public void VisitNestedClassDeclaration(INestedClassDeclarationWithSymbols node)
        {
            visitor.VisitNestedClassDeclaration(new NestedClassDeclarationWithSymbols(node));
        }

        public void VisitNestedDelegate(INestedDelegateWithSymbols node)
        {
            visitor.VisitNestedDelegate(new NestedDelegateWithSymbols(node));
        }

        public void VisitNestedDestructor(INestedDestructorWithSymbols node)
        {
            visitor.VisitNestedDestructor(new NestedDestructorWithSymbols(node));
        }

        public void VisitNestedEnum(INestedEnumWithSymbols node)
        {
            visitor.VisitNestedEnum(new NestedEnumWithSymbols(node));
        }

        public void VisitNestedEnumMember(INestedEnumMemberWithSymbols node)
        {
            visitor.VisitNestedEnumMember(new NestedEnumMemberWithSymbols(node));
        }

        public void VisitNestedInterface(INestedInterfaceWithSymbols node)
        {
            visitor.VisitNestedInterface(new NestedInterfaceWithSymbols(node));
        }

        public void VisitNestedInterfaceDeclaration(INestedInterfaceDeclarationWithSymbols node)
        {
            visitor.VisitNestedInterfaceDeclaration(new NestedInterfaceDeclarationWithSymbols(node));
        }

        public void VisitNestedStruct(INestedStructWithSymbols node)
        {
            visitor.VisitNestedStruct(new NestedStructWithSymbols(node));
        }

        public void VisitNestedStructDeclaration(INestedStructDeclarationWithSymbols node)
        {
            visitor.VisitNestedStructDeclaration(new NestedStructDeclarationWithSymbols(node));
        }

        public void VisitOperatorOverload(IOperatorOverloadWithSymbols node)
        {
            visitor.VisitOperatorOverload(new OperatorOverloadWithSymbols(node));
        }

        public Task VisitProjectAsync(IProjectWithSymbols node)
        {
            return visitor.VisitProjectAsync(ProjectWithSymbols.GetProject(node));
        }

        public void VisitProperty(IPropertyWithSymbols node)
        {
            visitor.VisitProperty(new PropertyWithSymbols(node));
        }

        public Task VisitSolutionAsync(ISolutionWithSymbols node)
        {
            return visitor.VisitSolutionAsync(SolutionWithSymbols.GetSolution(node));
        }

        public void VisitStruct(IStructWithSymbols node)
        {
            visitor.VisitStruct(new StructWithSymbols(node));
        }

        public void VisitStructDeclaration(IStructDeclarationWithSymbols node)
        {
            visitor.VisitStructDeclaration(new StructDeclarationWithSymbols(node));
        }
    }
}
