using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithLinqExpressions
{
    public abstract class LinqExpressionsVisitor
    {
        public virtual void VisitClassDeclaration(ClassDeclarationWithLinqExpressions node)
        {
        }

        public virtual void VisitClass(ClassWithLinqExpressions node)
        {
        }

        public virtual void VisitConstructor(ConstructorWithLinqExpressions node)
        {
        }

        public virtual void VisitConversionOperator(ConversionOperatorWithLinqExpressions node)
        {
        }

        public virtual void VisitDelegate(DelegateWithLinqExpressions node)
        {
        }

        public virtual void VisitDestructor(DestructorWithLinqExpressions node)
        {
        }

        public virtual void VisitDocument(DocumentWithLinqExpressions node)
        {
        }

        public virtual void VisitEnumMember(EnumMemberWithLinqExpressions node)
        {
        }

        public virtual void VisitEnum(EnumWithLinqExpressions node)
        {
        }

        public virtual void VisitEvent(EventWithLinqExpressions node)
        {
        }

        public virtual void VisitEventProperty(EventPropertyWithLinqExpressions node)
        {
        }

        public virtual void VisitField(FieldWithLinqExpressions node)
        {
        }

        public virtual void VisitIndexer(IndexerWithLinqExpressions node)
        {
        }

        public virtual void VisitInterfaceDeclaration(InterfaceDeclarationWithLinqExpressions node)
        {
        }

        public virtual void VisitInterface(InterfaceWithLinqExpressions node)
        {
        }

        public virtual void VisitMethod(MethodWithLinqExpressions node)
        {
        }

        public virtual void VisitNamespace(NamespaceWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedClassDeclaration(NestedClassDeclarationWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedClass(NestedClassWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedDelegate(NestedDelegateWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedDestructor(NestedDestructorWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedEnum(NestedEnumWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedEnumMember(NestedEnumMemberWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedInterfaceDeclaration(NestedInterfaceDeclarationWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedInterface(NestedInterfaceWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedStructDeclaration(NestedStructDeclarationWithLinqExpressions node)
        {
        }

        public virtual void VisitNestedStruct(NestedStructWithLinqExpressions node)
        {
        }

        public virtual void VisitOperatorOverload(OperatorOverloadWithLinqExpressions node)
        {
        }

        public virtual Task VisitProjectAsync(ProjectWithLinqExpressions node)
        {
            return null;
        }

        public virtual void VisitProperty(PropertyWithLinqExpressions node)
        {
        }

        public virtual Task VisitSolutionAsync(SolutionWithLinqExpressions node)
        {
            return null;
        }

        public virtual void VisitStructDeclaration(StructDeclarationWithLinqExpressions node)
        {
        }

        public virtual void VisitStruct(StructWithLinqExpressions node)
        {
        }
    }
}
